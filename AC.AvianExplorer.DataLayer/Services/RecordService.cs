using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Services
{
	public class RecordService
	{
		private readonly IRecordRepository _repo;

        public RecordService(IRecordRepository repo)
        {
            this._repo = repo;
		}

		public List<RecordDto> Search(string locationName, string familyName, string commonName, DateTime? recordTime, int userId, int? recordId)
		{
			List<RecordDto> data = _repo.Search(locationName, familyName, commonName, recordTime, userId, recordId);

			return data;
		}

		public List<RecordDto> FuzzySearch(string locationName, string familyName, string commonName, DateTime? recordTime,int userId, int? recordId)
		{
			List<RecordDto> data = _repo.FuzzySearch(locationName, familyName, commonName, recordTime, userId, recordId);

			return data;
		}

		public RecordEditDto Get(int id)
		{
			return _repo.Get(id);
		}

		public void Update(RecordEditDto dto)
		{
			List<RecordDto> data = _repo.Search(dto.LocationName, dto.FamilyName, dto.CommonName, dto.RecordTime,dto.UserId, null);
			if (data != null && data.Count > 0)
			{
				if (data[0].RecordId != dto.RecordId) throw new Exception("分類名稱已存在，不允許更新");
			}


			//若名稱唯一，允許新建紀錄
			_repo.Update(dto);
		}

		public void Create(RecordAddDto dto)
		{
			//檢查name是否已存在
			var data = _repo.Search(dto.LocationName, dto.FamilyName, dto.CommonName, dto.RecordTime,dto.UserId, null);
			if (data != null && data.Count > 0) throw new Exception("分類名稱已存在");

			//若名稱唯一，允許新建紀錄
			_repo.Create(dto);
		}

		public void Delete(int id)
		{
			_repo.Delete(id);
		}
	}
}
