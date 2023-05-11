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

		private readonly int currentUserId;
		public FormSpecies(int currentUserId)
		{
			InitializeComponent();

			this.currentUserId = currentUserId;
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

			dto = service.FuzzySearch(commonName, speciesName, familyName, null);

			dataGridView1.DataSource = dto;
			
			int familyQuantity = dto.Select(x => x.FamilyName)
				                    .Distinct()
									.Count();

			int speciesQuantity = dto.Select(x => x.CommonName)
									 .Distinct()
									 .Count();

			label4.Text = $"共{familyQuantity}科{speciesQuantity}種";
		}

		private void btnAddSpecie_Click(object sender, EventArgs e)
		{
			if (currentUserId != 1)
			{
				MessageBox.Show("非管理員不得更動名錄");
				return;
			}

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
			if (currentUserId == 1)
			{
				if (e.RowIndex < 0) return;//點到標題欄不算

				int speciesId = dto[e.RowIndex].SpeciesId;

				var frm = new FormEditSpecies(speciesId);
				frm.Owner = this;
				frm.ShowDialog();
			}
		}

		
	}
}
