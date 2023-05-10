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

		public List<RecordDto> Search(string locationName, string familyName, string commonName, int? recordId)
		{
			List<RecordDto> data = _repo.Search(locationName, familyName, commonName, recordId);

			return data;
		}

		public RecordEditDto Get(int id)
		{
			return _repo.Get(id);
		}
	}
}
