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

			var location = service.Search(null, null, null, null)
								  .Where(x => x.UserId == currentUserId)
								  .Select(x => x.LocationName)
								  .Distinct()
								  .ToList();

			location.Insert(0, "");
			comboBoxLocation.DataSource = location;

			var family = service.Search(null, null, null, null)
									.Where(x => x.UserId == currentUserId)
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

			var dto = service.Search(locationName, familyName, commonName)
							 .Where(x => x.UserId == currentUserId)
							 .ToList();

			dataGridView1.DataSource = dto;

			int familyQuantity = dto.Select(x => x.FamilyName)
									.Distinct()
									.Count();

			int speciesQuantity = dto.Select(x => x.CommonName)
				                     .Distinct()
									 .Count();

			int totalQuantity = dto.Select(x => x.Total)
								   .Sum();



			labelDescription.Text = $"共紀錄{familyQuantity}科{speciesQuantity}種，{totalQuantity}隻次";
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

			var familyName = service.Search(comboBoxLocation.SelectedItem.ToString(), null, null, null)
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
