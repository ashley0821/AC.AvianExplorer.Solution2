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
	public partial class FormSpecies : Form, IGrid
	{
		private List<SpeciesDto> dto;
		public FormSpecies()
		{
			InitializeComponent();
		}

		private void FormSpecies_Load(object sender, EventArgs e)
		{
			Display();

			ISpeciesRepository categoryRepository = new SpeciesRepository();
			SpeciesSercive service = new SpeciesSercive(categoryRepository);

			List<string> FamilyName = service.Search(null, null, null, null)
							   .Select(s => s.FamilyName)
							   .Distinct()
							   .ToList();

			FamilyName.Insert(0, "");

			comboBoxFamilyName.DataSource = FamilyName;
		}

		private void btnSearchSpecies_Click(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			ISpeciesRepository categoryRepository = new SpeciesRepository();
			SpeciesSercive service = new SpeciesSercive(categoryRepository);

			string commonName = txtCommonName.Text;
			string speciesName = txtSpeciesName.Text;
			string familyName = comboBoxFamilyName.Text;

			dto = service.Search(commonName, speciesName, familyName, null);

			dataGridView1.DataSource = dto;
			
		}

		private void btnAddSpecie_Click(object sender, EventArgs e)
		{
			var frm = new FormAddSpecies();

			//owner縮小時，視窗會一起縮小
			//視窗關掉後，owner會自動更新
			frm.Owner = this;

			frm.ShowDialog();
		}

		private void comboBoxFamilyName_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			txtSpeciesName.Text = string.Empty;
			txtCommonName.Text = string.Empty;
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;//點到標題欄不算

			int speciesId = dto[e.RowIndex].SpeciesId;

			var frm = new FormEditSpecies(speciesId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		
	}
}
