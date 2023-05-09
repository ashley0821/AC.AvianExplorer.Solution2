using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Infra;
using AC.AvianExplorer.DataLayer.Interfaces;
using AC.AvianExplorer.DataLayer.UserServices;
using AC.AvianExplorer.WinApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AC.AvianExplorer.WinApp
{
	public partial class FormSignup : Form
	{
		public FormSignup()
		{
			InitializeComponent();
		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			try
			{
				string userName = txtName.Text;
				string userPwd = txtPwd.Text;

				if (string.IsNullOrEmpty(userName)) { throw new ArgumentNullException(nameof(userName), "帳號必填"); }
				if (string.IsNullOrEmpty(userPwd)) { throw new ArgumentNullException(nameof(userPwd), "密碼必填"); }

				UserAddVM vm = new UserAddVM();
				vm.UserName = userName;
				vm.UserPwd = userPwd;

				IUserRepository userRepository = new UserRepository();
				UserService service = new UserService(userRepository);

				UserAddDto dto = vm.ToDto();

				service.Create(dto);

				this.Close();
			}
			catch (ArgumentNullException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
