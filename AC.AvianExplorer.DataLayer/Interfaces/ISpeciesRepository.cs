using AC.AvianExplorer.DataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Interfaces
{
	public interface ISpeciesRepository
	{
		void Create(SpeciesAddDto dto);
		void Update(SpeciesEditDto dto);
		void Delete(int speciesId);
		SpeciesDto Get(int speciesId);

		//需要join資料表時，回傳dto比較恰當
		List<SpeciesDto> Search(string commonName, string speciesName, string familyName, int? speciesId);
	}
}
