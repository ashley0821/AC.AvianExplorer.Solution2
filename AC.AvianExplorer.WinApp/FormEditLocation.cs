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
using System.Xml.Linq;

namespace AC.AvianExplorer.WinApp
{
	public partial class FormEditLocation : Form
	{
		private readonly int locationId;
		private readonly int currentUserId;
		public FormEditLocation(int locationId, int currentUserId)
		{
			InitializeComponent();

			this.locationId = locationId;
			this.currentUserId = currentUserId;
		}

		private void FormEditLocation_Load(object sender, EventArgs e)
		{
			ILocationRepository categoryRepository = new LocationRepository();
			LocationService service = new LocationService(categoryRepository);

			LocationDto dto = service.Get(this.locationId);

			txtLocationName.Text = dto.LocationName;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string locationName = txtLocationName.Text;

			if (string.IsNullOrEmpty(locationName))
			{
				MessageBox.Show("名稱必填");
				return;
			}

			LocationEditDto dto = new LocationEditDto
			{
				LocationId = locationId,
				LocationName = locationName,
				UserId = currentUserId
			};

			ILocationRepository categoryRepository = new LocationRepository();
			LocationService service = new LocationService(categoryRepository);

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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("刪除地點將會一併刪除資料，請問是否確認刪除?", "刪除地點", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				// 如果使用者選擇 Yes，刪除地點資料
				ILocationRepository categoryRepository = new LocationRepository();
				LocationService service = new LocationService(categoryRepository);

				service.Delete(this.locationId);

				//新增完成，關閉自己，並通知Owner更新內容
				IGrid owner = this.Owner as IGrid;
				if (owner == null)
				{
					MessageBox.Show("忘記把owner實作IGrid了，請補一下");
				}
				else
				{
					owner.Display();
				}

				this.DialogResult = DialogResult.OK;
			}
			// 如果使用者選擇 No，則不做任何事情，直接返回
		}
	}
}
