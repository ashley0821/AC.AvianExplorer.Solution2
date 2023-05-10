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
using System.Xml.Linq;

namespace AC.AvianExplorer.WinApp
{
	public partial class FormRecord : Form , IGrid
	{
		private readonly int currentUserId;

		private List<RecordDto> dto;
		public FormRecord(int currentUserId)
		{
			InitializeComponent();
			this.currentUserId = currentUserId;	
		}

		public void Display()
		{
			string locationName = comboBoxLocation.Text;
			string familyName = comboBoxFamilyName.Text;
			string commonName = txtCommonName.Text;

			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			dto = service.Search(locationName, familyName, commonName, null)
				         .Where(x => x.UserId == currentUserId)
					     .ToList();

			dataGridView1.DataSource = dto;
		}

		private void btnSearchRecord_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void FormRecord_Load(object sender, EventArgs e)
		{
			Display();

			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			var familyName = service.Search(null, null, null, null)
								    .Where(x => x.UserId == currentUserId)
									.Select(x => x.FamilyName) 
									.Distinct()
									.ToList();

			var location = service.Search(null, null,null,null)
						          .Where(x => x.UserId == currentUserId)
								  .Select(x => x.LocationName)
								  .Distinct()
						          .ToList();

			familyName.Insert(0, "");

			location.Insert(0, "");

			comboBoxFamilyName.DataSource = familyName;
			comboBoxLocation.DataSource = location;
		}

		private void comboBoxFamilyName_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtCommonName.Text = string.Empty;
			Display();
		}

		private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxFamilyName.Text = string.Empty;
			txtCommonName.Text = string.Empty;
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;//點到標題欄不算

			int speciesId = dto[e.RowIndex].RecordId;

			var frm = new FormEditRecord(speciesId, currentUserId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
