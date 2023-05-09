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
	public partial class FormAddLocation : Form
	{
		private readonly int currentUserId;
		public FormAddLocation(int currentUserId)
		{
			InitializeComponent();

			this.currentUserId = currentUserId;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string locationName = txtLocationName.Text;

			if (string.IsNullOrEmpty(locationName))
			{
				MessageBox.Show("地點名稱必填");
				return;
			}

			LocationAddDto dto = new LocationAddDto
			{
				LocationName = locationName,
				UserId = currentUserId
			};

			ILocationRepository categoryRepository = new LocationRepository();
			LocationService service = new LocationService(categoryRepository);

			service.Create(dto);

			//新增完成，關閉自己，並通知Owner更新內容
			//泛化 : 把要處理的表單轉成介面
			IGrid owner = (IGrid)this.Owner;//= this.Owner as IGrid 比較溫和 沒有轉型成功會變成null
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
	}
}
