using AC.AvianExplorer.DataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Interfaces
{
	public interface IRecordRepository
	{
		void Create(RecordAddDto dto);
		void Update(RecordEditDto dto);
		void Delete(int recordId);
		RecordEditDto Get(int recordId);
		List<RecordDto> Search(string locationName, string familyName, string commonName, DateTime? recordTime, int? userId, int? recordId);

		List<RecordDto> FuzzySearch(string locationName, string familyName, string commonName, DateTime? recordTime, int? userId, int? recordId);
	}
}
