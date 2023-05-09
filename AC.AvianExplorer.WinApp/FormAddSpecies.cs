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
	public partial class FormAddSpecies : Form
	{
		public FormAddSpecies()
		{
			InitializeComponent();
		}

		private void btnAddSpecies_Click(object sender, EventArgs e)
		{
			string commonName = txtCommonName.Text;
			string speciesName = txtSpeciesName.Text;
			string familyName = txtFamilyName.Text;

			if (string.IsNullOrEmpty(commonName) || string.IsNullOrEmpty(speciesName) || string.IsNullOrEmpty(familyName))
			{
				MessageBox.Show("三個欄位皆必填");
				return;
			}

			SpeciesAddDto addDto = new SpeciesAddDto
			{
				CommonName = commonName,
				SpeciesName = speciesName,
				FamilyName = familyName,
			};

			ISpeciesRepository categoryRepository = new SpeciesRepository();
			SpeciesSercive service = new SpeciesSercive(categoryRepository);

			service.Create(addDto);

			IGrid owner = (IGrid)this.Owner;//= this.Owner as IGrid 比較溫和 沒有轉型成功會變成null
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
	}
}
