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
			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			string locationName = comboBoxLocation.Text;
			string familyName = comboBoxFamilyName.Text;
			string commonName = txtCommonName.Text;

			dto = service.FuzzySearch(locationName, familyName, commonName,null, currentUserId, null)
					     .ToList();

			dataGridView1.DataSource = dto;
		}

		private void btnSearchRecord_Click(object sender, EventArgs e)
		{
			Display();

		}

		public void SetComboBox()
		{
			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			var location = service.Search(null, null, null,null, currentUserId, null)
								  .Select(x => x.LocationName)
								  .Distinct()
								  .ToList();

			location.Insert(0, "");
			comboBoxLocation.DataSource = location;

			var family = service.Search(null, null, null,null, currentUserId, null)
									.Select(x => x.FamilyName)
									.Distinct()
									.ToList();

			family.Insert(0, "");

			comboBoxFamilyName.DataSource = family;
		}

		private void FormRecord_Load(object sender, EventArgs e)
		{
			Display();

			SetComboBox();
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

			IRecordRepository categoryRepository = new RecordRepository();
			RecordService service = new RecordService(categoryRepository);

			var familyName = service.Search(comboBoxLocation.SelectedItem.ToString(), null, null, null, currentUserId, null)
									.Where(x => x.UserId == currentUserId)
									.Select(x => x.FamilyName)
									.Distinct()
									.ToList();

			familyName.Insert(0, "");
			comboBoxFamilyName.DataSource = familyName;

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

		private void btnAddRecord_Click(object sender, EventArgs e)
		{
			var frm = new FormAddRecord(currentUserId);

			//owner縮小時，視窗會一起縮小
			//視窗關掉後，owner會自動更新
			frm.Owner = this;

			frm.ShowDialog();
		}

		private void btnGrid_Click(object sender, EventArgs e)
		{
			var frm = new FormGrid(currentUserId);

			//owner縮小時，視窗會一起縮小
			//視窗關掉後，owner會自動更新
			frm.Owner = this;

			frm.ShowDialog();
		}
	}
}
