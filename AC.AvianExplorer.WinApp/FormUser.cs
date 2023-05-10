using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Infra;
using AC.AvianExplorer.DataLayer.Interfaces;
using AC.AvianExplorer.DataLayer.Services;
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

namespace AC.AvianExplorer.WinApp
{
	public partial class FormUser : Form
	{
		private readonly int currentUserId;
		public FormUser(int currentUserId)
		{
			InitializeComponent();

			this.currentUserId = currentUserId;
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			string userName = txtName.Text;
			string userPwd = txtPwd.Text;

			if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
			{
				MessageBox.Show("所有欄位皆必填");
				return;
			}

			UserEditVM vm = new UserEditVM
			{
				UserId = currentUserId,
				UserName = userName,
				UserPwd = userPwd
			};

			UserEditDto dto = vm.ToDto();

			IUserRepository categoryRepository = new UserRepository();
			UserService service = new UserService(categoryRepository);

			try
			{
				service.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因是:" + ex.Message);
				return;
			}

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單

			var owner = this.Owner as FormMain;
			owner.Close();
		}

		private void FormUser_Load(object sender, EventArgs e)
		{
			IUserRepository categoryRepository = new UserRepository();
			UserService service = new UserService(categoryRepository);

			UserEditDto dto = service.Get(currentUserId);

			UserEditVM vm = dto.ToViewModel();

			txtName.Text = dto.UserName;
			txtPwd.Text = dto.UserPwd;
		}
	}
}
