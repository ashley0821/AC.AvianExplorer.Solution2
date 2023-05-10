using AC.AvianExplorer.DataLayer.Infra;
using AC.AvianExplorer.DataLayer.Interfaces;
using AC.AvianExplorer.DataLayer.UserServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC.AvianExplorer.WinApp
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			IUserRepository userRepository = new UserRepository();
			UserService service = new UserService(userRepository);

			try
			{
				bool validationResult = service.IsValid(txtName.Text, txtPwd.Text);
				if (validationResult == false)
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次");
					return;
				}

				var currentUser = service.GetByName(txtName.Text);
				int currentUserId = currentUser.UserId;

				//清空表單值，以便下次顯示十，不會有值
				txtName.Text = string.Empty;
				txtPwd.Text = string.Empty;

				var frm = new FormMain(currentUserId);
				frm.Owner = this;

				//不能將FormLogin關閉，只能隱藏
				//不然現在的app就會視同結束
				this.Hide();

				//稍後FormMain關閉時，再將FormLogin顯示
				frm.ShowDialog();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			var frm = new FormSignup();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			//txtName.Text = "aaa";
			//txtPwd.Text = "123";//測試用
		}
	}
}
