using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AC.AvianExplorer.DataLayer.Services
{
	public class SpeciesSercive
	{
		private readonly ISpeciesRepository _repo;

		public SpeciesSercive(ISpeciesRepository repo)
		{
			_repo = repo;
		}

		public List<SpeciesDto> Search(string commonName, string speciesName, string familyName, int? speciesId)
		{
			List<SpeciesDto> data = _repo.Search(commonName, speciesName, familyName, speciesId);

			return data;
		}

		public void Create(SpeciesAddDto dto)
		{
			//檢查name是否已存在
			var data = _repo.Search(dto.CommonName, dto.SpeciesName, dto.FamilyName , null);
			if (data != null && data.Count > 0) throw new Exception("分類名稱已存在");

			//若名稱唯一，允許新建紀錄
			_repo.Create(dto);
		}
	}
}
