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
	public partial class FormGrid : Form
	{
		private readonly int currentUserId;
		public FormGrid(int currentUserId)
		{
			InitializeComponent();

			this.currentUserId = currentUserId;
		}

		private void FormGrid_Load(object sender, EventArgs e)
		{
			Display();

			SetComboBox();
		}

		public void SetComboBox()
		{
			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			var location = service.Search(null, null, null, null, currentUserId, null)
								  .Select(x => x.LocationName)
								  .Distinct()
								  .ToList();

			location.Insert(0, "");
			comboBoxLocation.DataSource = location;

			var family = service.Search(null, null, null, null, currentUserId, null)
									.Select(x => x.FamilyName)
									.Distinct()
									.ToList();

			family.Insert(0, "");

			comboBoxFamilyName.DataSource = family;
		}

		public void Display()
		{
			IGridRepository categoryRepository = new GridRepository();
			GridService service = new GridService(categoryRepository);

			string locationName = comboBoxLocation.Text;
			string familyName = comboBoxFamilyName.Text;
			string commonName = txtCommonName.Text;

			var dto = service.Search(locationName, familyName, commonName,	currentUserId)
							 .ToList();

			dataGridView1.DataSource = dto;

			var dto2 = service.TopThree(locationName, familyName, commonName, currentUserId)
							 .ToList();

			dataGridView2.DataSource = dto2;	


			int familyQuantity = dto.Select(x => x.FamilyName)
									.Distinct()
									.Count();

			int speciesQuantity = dto.Select(x => x.CommonName)
				                     .Distinct()
									 .Count();

			int totalQuantity = dto.Select(x => x.Total)
								   .Sum();

			string description = "";

			for(int i = 0; i < dto2.Count(); i++)
			{
				string name = dto2[i].CommonName.ToString();
				string quantity = dto2[i].Total.ToString();

				if(i == (dto2.Count() -1))
				{
					description = description + "及" + name + quantity + "隻次";
				}
				else
				{
					description = description + "、" + name + quantity + "隻次";
				}

				
			}


			description = description.Substring(1);

			labelDescription.Text = $"共記錄{familyQuantity}科{speciesQuantity}種{totalQuantity}隻次。\r\n記錄數量最多的物種分別為" + description + "。";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxFamilyName.Text = string.Empty;
			txtCommonName.Text = string.Empty;

			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			var familyName = service.Search(comboBoxLocation.SelectedItem.ToString(), null, null,null, currentUserId, null)
									.Where(x => x.UserId == currentUserId)
									.Select(x => x.FamilyName)
									.Distinct()
									.ToList();

			familyName.Insert(0, "");
			comboBoxFamilyName.DataSource = familyName;

			Display();
		}

		private void comboBoxFamilyName_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtCommonName.Text = string.Empty;
			Display();
		}
	}
}
