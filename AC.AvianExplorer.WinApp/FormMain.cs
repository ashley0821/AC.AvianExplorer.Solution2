using AC.AvianExplorer.DataLayer.Cores;
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
	public partial class FormMain : Form
	{
		private readonly int currentUserId;
		public FormMain(int currentUserId)
		{
			InitializeComponent();
			this.currentUserId = currentUserId;
		}

		private void btmLocation_Click(object sender, EventArgs e)
		{
			var frm = new FormLocation(currentUserId);
			frm.ShowDialog();	
		}

		private void btnSpecies_Click(object sender, EventArgs e)
		{
			var frm = new FormSpecies();
			frm.ShowDialog();

		}
	}
}
