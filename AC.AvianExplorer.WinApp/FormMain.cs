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
			var frm = new FormSpecies(currentUserId);
			frm.ShowDialog();

		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void btnRecord_Click(object sender, EventArgs e)
		{
			var frm = new FormRecord(currentUserId);
			frm.ShowDialog();
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			var frm = new FormUser(currentUserId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
