using AC.AvianExplorer.DataLayer.Cores;
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
	public partial class FormLocation : Form, IGrid
	{
		private List<LocationDto> dto;

		private readonly int currentUserId;
		public FormLocation(int currentUserId)
		{
			InitializeComponent();
			this.currentUserId = currentUserId;
		}

		private void FormLocation_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			string name = txtLocationName.Text;

			ILocationRepository categoryRepository = new LocationRepository();
			LocationService service = new LocationService(categoryRepository);

			dto = service.FuzzySearch(name, currentUserId, null)
						.ToList();

			dataGridView1.DataSource = dto;
		}

		private void btnAddLocation_Click(object sender, EventArgs e)
		{
			var frm = new FormAddLocation(currentUserId);

			//owner縮小時，視窗會一起縮小
			//視窗關掉後，owner會自動更新
			frm.Owner = this;

			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;//點到標題欄不算

			int locationId = dto[e.RowIndex].LocationId;

			var frm = new FormEditLocation(locationId, currentUserId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
