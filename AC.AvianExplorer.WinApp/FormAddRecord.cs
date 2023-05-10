using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Infra;
using AC.AvianExplorer.DataLayer.Interfaces;
using AC.AvianExplorer.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC.AvianExplorer.WinApp
{
	public partial class FormAddRecord : Form
	{
		private readonly int currentUserId;
		public FormAddRecord(int currentUserId)
		{
			InitializeComponent();

			this.currentUserId = currentUserId;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtQuantity.Text, out int  quantity);

			if (isInt == false)
			{
				MessageBox.Show("請確認各欄位格式正確");
				return;	
			}

			string locationName = comboBoxLocation.Text;
			string familyName = comboBoxFamilyName.Text;
			string commonName = comboBoxCommonName.Text;
			DateTime recordTime = dateTimePickerRecordTime.Value;

			RecordAddDto addDto = new RecordAddDto
			{
				UserId = currentUserId,
				LocationName = locationName,
				FamilyName = familyName,
				CommonName = commonName,
				RecordTime = recordTime,
				Quantity = quantity
			};

			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);


			try
			{
				service.Create(addDto);
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); return; }
			

			//新增完成，關閉自己，並通知Owner更新內容
			//泛化 : 把要處理的表單轉成介面
			IGrid owner = (IGrid)this.Owner;//= this.Owner as IGrid 比較溫和 沒有轉型成功會變成null
			
			owner.Display();

			FormRecord ownrForm = this.Owner as FormRecord;

			if (ownrForm != null)
			{
				ownrForm.SetComboBox();
			}

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單

			
		}

		private void FormAddRecord_Load(object sender, EventArgs e)
		{
			ILocationRepository categoryRepository = new LocationRepository();
			LocationService service = new LocationService(categoryRepository);

			var location = service.Search(null, null)
								  .Where(x => x.UserId == currentUserId)
								  .Select(x => x.LocationName)
								  .Distinct()
								  .ToList();

			comboBoxLocation.DataSource = location;

			ISpeciesRepository categoryRepository2 = new SpeciesRepository();
			SpeciesSercive service2 = new SpeciesSercive(categoryRepository2);

			var familyName = service2.Search(null, null, null, null)
									.Select(x => x.FamilyName)
									.Distinct()
									.ToList();

			comboBoxFamilyName.DataSource = familyName;

			var commonName = service2.Search(null, null, comboBoxFamilyName.SelectedItem.ToString(), null)
									 .Select(x => x.CommonName)
									  .Distinct()
									  .ToList();

			comboBoxCommonName.DataSource = commonName;
		}

		private void comboBoxFamilyName_SelectedIndexChanged(object sender, EventArgs e)
		{
			ISpeciesRepository categoryRepository2 = new SpeciesRepository();
			SpeciesSercive service2 = new SpeciesSercive(categoryRepository2);

			var commonName = service2.Search(null, null, comboBoxFamilyName.SelectedItem.ToString(), null)
									 .Select(x => x.CommonName)
									  .Distinct()
									  .ToList();

			comboBoxCommonName.DataSource = commonName;
		}
	}
}
