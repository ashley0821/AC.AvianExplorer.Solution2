using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Services
{
	public class LocationService
	{
		private readonly ILocationRepository _repo;

		public LocationService(ILocationRepository repo)
		{
			_repo = repo;
		}

		public void Create(LocationAddDto dto)
		{
			//檢查name是否已存在
			var data = _repo.Search(dto.LocationName, null);
			if (data != null && data.Count > 0) throw new Exception("分類名稱已存在");

			//若名稱唯一，允許新建紀錄
			_repo.Create(dto);
		}

		public void Update(LocationEditDto dto)
		{
			//檢查name是否已存在
			List<LocationDto> data = _repo.Search(dto.LocationName, null);
			if (data != null && data.Count > 0)
			{
				if (data[0].LocationId != dto.LocationId) throw new Exception("分類名稱已存在，不允許更新");
			}


			//若名稱唯一，允許新建紀錄
			_repo.Update(dto);
		}

		public void Delete(int locationId)
		{
			_repo.Delete(locationId);
		}

		public List<LocationDto> Search(string name, int? id)
		{
			List<LocationDto> data = _repo.Search(name, id);

			return data;
		}

		public LocationDto Get(int locationId)
		{

			return _repo.Get(locationId);
		}
	}
}
