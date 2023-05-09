﻿using AC.AvianExplorer.DataLayer.Dtos;
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
	public partial class FormSpecies : Form
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

		
	}
}