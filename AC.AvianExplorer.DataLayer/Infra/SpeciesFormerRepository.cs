using AC.AvianExplorer.DataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Infra
{
	public class SpeciesFormerRepository
	{
		public List<SpeciesDto> Search()
		{
			string sql = "SELECT * FROM SpeciesFormer";

			sql += " ORDER BY FamilyName";

			Func<SqlDataReader, SpeciesDto> funcAssembler = reader =>
			{
				return new SpeciesDto
				{
					SpeciesId = reader.GetInt32("SpeciesId", 0),
					CommonName = reader.GetString("CommonName"),
					SpeciesName = reader.GetString("SpeciesName"),
					FamilyName = reader.GetString("FamilyName")
				};
			};

			return sqlDb.Search<SpeciesDto>(sqlDb.GetConnection, funcAssembler, sql, null);
		}
	}
}
