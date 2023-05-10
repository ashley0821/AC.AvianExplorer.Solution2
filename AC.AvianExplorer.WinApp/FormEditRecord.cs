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
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC.AvianExplorer.WinApp
{
	public partial class FormEditRecord : Form
	{

		private readonly int recordId;
		private readonly int currentUserId;
		public FormEditRecord(int recordId, int currentUserId)
		{
			InitializeComponent();
			this.recordId = recordId;
			this.currentUserId = currentUserId;
		}

		private void FormEditRecord_Load(object sender, EventArgs e)
		{
			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			RecordEditDto dto = service.Get(recordId);



			var location = service.Search(null, null, null, null)
								  .Where(x => x.UserId == currentUserId)
								  .Select(x => x.LocationName)
								  .Distinct()
								  .ToList();

			comboBoxLocation.DataSource = location;
			comboBoxLocation.SelectedItem = dto.LocationName;


			ISpeciesRepository categoryRepository2 = new SpeciesRepository();
			SpeciesSercive service2 = new SpeciesSercive(categoryRepository2);

			var familyName = service2.Search(null, null, null, null)
									.Select(x => x.FamilyName)
									.Distinct()
									.ToList();
			
			comboBoxFamilyName.DataSource = familyName;
			comboBoxFamilyName.SelectedItem = dto.FamilyName;

			var commonName = service2.Search(null, null, comboBoxFamilyName.SelectedItem.ToString(), null)
									 .Select(x => x.CommonName)
									  .Distinct()
									  .ToList();

			comboBoxCommonName.DataSource = commonName;
			comboBoxCommonName.SelectedItem = dto.CommonName;

			txtQuantity.Text = dto.Quantity.ToString();
			txtRecordTime.Text = dto.RecordTime.ToString("yyyy/MM/dd");
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string location = comboBoxLocation.Text;
			string familyName = comboBoxFamilyName.Text;
			string commonName = comboBoxCommonName.Text;

			bool isDate = DateTime.TryParse(txtRecordTime.Text, out DateTime recordTime);
			bool isInt = int.TryParse(txtQuantity.Text, out int quantity);

			if(isDate == false || isInt == false)
			{
				MessageBox.Show("請確認各欄位格式正確");
				return;
			}

			RecordEditDto editDto = new RecordEditDto
			{
				RecordId = recordId,
				UserId = currentUserId,
				LocationName = location,
				FamilyName = familyName,
				CommonName = commonName,
				RecordTime = recordTime,
				Quantity = quantity
			};

			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			try
			{
				service.Update(editDto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因是:" + ex.Message);
				return;
			}

			//新增完成，關閉自己，並通知Owner更新內容
			IGrid owner = this.Owner as IGrid;//若用as轉型失敗會傳回null，不會丟出例外，會比顯式轉型好

			if (owner == null)
			{
				MessageBox.Show("忘記把owner實作IGrid了，請補一下");
			}
			else
			{
				owner.Display();
			}

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
	}
}
