using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Services
{
	public class GridService
	{
		private readonly IGridRepository _repo;

		public GridService(IGridRepository repo)
		{
			this._repo = repo;
		}

		public List<GridDto> Search(string locationName, string familyName, string commonName, int userId)
		{
			List<GridDto> data = _repo.Search(locationName, familyName, commonName, userId);

			return data;
		}

		public List<GridDto> TopThree(string locationName, string familyName, string commonName, int userId)
		{
			List<GridDto> data = _repo.TopThree(locationName, familyName, commonName, userId);

			return data;
		}
	}
}
