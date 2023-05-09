using AC.AvianExplorer.DataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Interfaces
{
	public interface ILocationRepository
	{
		void Create(LocationAddDto dto);
		void Update(LocationEditDto dto);
		void Delete(int locationId);
		LocationDto Get(int locationId);

		//需要join資料表時，回傳dto比較恰當
		List<LocationDto> Search(string locationName, int? locationId);
	}
}
