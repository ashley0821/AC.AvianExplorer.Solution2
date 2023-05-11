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

		private readonly UserEntity currentUser;
		public FormMain(int currentUserId , UserEntity user)
		{
			InitializeComponent();
			this.currentUserId = currentUserId;
			this.currentUser = user;
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			string name = currentUser.UserName.ToString();
			label2.Text = $"{name}用戶您好，歡迎使用";
		}
	}
}
