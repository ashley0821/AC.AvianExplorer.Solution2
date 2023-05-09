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
	public partial class FormEditSpecies : Form
	{
		private readonly int speciesId;
		public FormEditSpecies(int speciesId)
		{
			InitializeComponent();

			this.speciesId = speciesId;
		}

		private void FormEditSpecies_Load(object sender, EventArgs e)
		{
			ISpeciesRepository categoryRepository = new SpeciesRepository();
			SpeciesSercive service = new SpeciesSercive(categoryRepository);

			var dto = service.Get(speciesId);

			txtCommonName.Text = dto.CommonName;
			txtSpeciesName.Text = dto.SpeciesName;
			txtFamilyName.Text = dto.FamilyName;
		}

		private void btnUpdateSpecies_Click(object sender, EventArgs e)
		{
			string commonName = txtCommonName.Text;
			string speciesName = txtSpeciesName.Text;
			string familyName = txtFamilyName.Text;

			if (string.IsNullOrEmpty(commonName) || string.IsNullOrEmpty(speciesName) || string.IsNullOrEmpty(familyName))
			{
				MessageBox.Show("三個欄位皆必填");
				return;
			}

			SpeciesEditDto dto = new SpeciesEditDto
			{
				SpeciesId = speciesId,
				SpeciesName = speciesName,
				FamilyName = familyName,
				CommonName = commonName,
			};

			ISpeciesRepository categoryRepository = new SpeciesRepository();
			SpeciesSercive service = new SpeciesSercive(categoryRepository);

			try
			{
				service.Update(dto);
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
