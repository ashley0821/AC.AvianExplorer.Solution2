using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Infra
{
	public class SpeciesRepository : ISpeciesRepository
	{
		public void Create(SpeciesAddDto dto)
		{
			string sql = "INSERT INTO Species (CommonName, SpeciesName, FamilyName) VALUES(@CommonName, @SpeciesName, @FamilyName)";

			var parameter = SqlParameterBuilder.create()
				.AddNvarchar("@CommonName", 50, dto.CommonName)
				.AddNvarchar("@SpeciesName", 50, dto.SpeciesName)
				.AddNvarchar("@FamilyName", 50, dto.FamilyName)
				.Build();

			sqlDb.Create(sqlDb.GetConnection, sql, parameter);
		}

		public void Delete(int speciesId)
		{
			throw new NotImplementedException();
		}

		public SpeciesEditDto Get(int speciesId)
		{
			string sql = "SELECT * FROM Species WHERE SpeciesId = " + speciesId;

			Func<SqlDataReader, SpeciesEditDto> funcAssembler = reader =>
			{
				return new SpeciesEditDto
				{
					SpeciesId = speciesId,
					CommonName = reader.GetString("CommonName"),
					SpeciesName = reader.GetString("SpeciesName"),
					FamilyName = reader.GetString("FamilyName")
				};
			};

			return sqlDb.Get<SpeciesEditDto>(sqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<SpeciesDto> Search(string commonName, string speciesName, string familyName, int? speciesId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = "SELECT * FROM Species";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(commonName) == false)
			{
				where += " AND CommonName = @CommonName ";
				parameters.Add(new SqlParameter("@CommonName", System.Data.SqlDbType.NVarChar, 50) { Value = commonName });
			}

			if (string.IsNullOrEmpty(speciesName) == false)
			{
				where += " AND SpeciesName = @SpeciesName ";
				parameters.Add(new SqlParameter("@SpeciesName", System.Data.SqlDbType.NVarChar, 50) { Value = speciesName });
			}

			if (string.IsNullOrEmpty(familyName) == false)
			{
				where += " AND FamilyName = @FamilyName ";
				parameters.Add(new SqlParameter("@FamilyName", System.Data.SqlDbType.NVarChar, 50) { Value = familyName });
			}

			if (speciesId.HasValue)
			{
				where += " AND SpeciesId =" + speciesId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

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

			return sqlDb.Search<SpeciesDto>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public List<SpeciesDto> FuzzySearch(string commonName, string speciesName, string familyName, int? speciesId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = "SELECT * FROM Species";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(commonName) == false)
			{
				where += " AND CommonName LIKE '%' + @CommonName + '%'";
				parameters.Add(new SqlParameter("@CommonName", System.Data.SqlDbType.NVarChar, 50) { Value = commonName });
			}

			if (string.IsNullOrEmpty(speciesName) == false)
			{
				where += " AND SpeciesName LIKE '%' + @SpeciesName + '%'";
				parameters.Add(new SqlParameter("@SpeciesName", System.Data.SqlDbType.NVarChar, 50) { Value = speciesName });
			}

			if (string.IsNullOrEmpty(familyName) == false)
			{
				where += " AND FamilyName = @FamilyName ";
				parameters.Add(new SqlParameter("@FamilyName", System.Data.SqlDbType.NVarChar, 50) { Value = familyName });
			}

			if (speciesId.HasValue)
			{
				where += " AND SpeciesId =" + speciesId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

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

			return sqlDb.Search<SpeciesDto>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(SpeciesEditDto dto)
		{
			string sql = "UPDATE Species SET CommonName = @CommonName, SpeciesName = @SpeciesName, FamilyName = @FamilyName WHERE SpeciesId = @SpeciesId";

			var parameters = SqlParameterBuilder.create()
							 .AddInt("@SpeciesId", dto.SpeciesId)
							 .AddNvarchar("@CommonName", 50, dto.CommonName)
							 .AddNvarchar("@SpeciesName", 50, dto.SpeciesName)
							 .AddNvarchar("@FamilyName", 50, dto.FamilyName)
							 .Build();

			sqlDb.UpdateOrDelete(sqlDb.GetConnection, sql, parameters);
		}
	}
}
