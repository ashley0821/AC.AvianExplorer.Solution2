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
	public class GridRepository : IGridRepository
	{
		public List<GridDto> Search(string locationName, string familyName, string commonName)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = @"SELECT　Records.UserId, FamilyName, CommonName, sum(Quantity)as Total
FROM Records
join Locations on Records.LocationId = Locations.LocationId
Join [dbo].[Species] on Species.SpeciesId = Records.SpeciesId";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(locationName) == false)
			{
				where += " AND LocationName LIKE '%' + @LocationName + '%'";
				parameters.Add(new SqlParameter("@LocationName", System.Data.SqlDbType.NVarChar, 50) { Value = locationName });
			}

			if (string.IsNullOrEmpty(familyName) == false)
			{
				where += " AND FamilyName LIKE '%' + @FamilyName + '%'";
				parameters.Add(new SqlParameter("@FamilyName", System.Data.SqlDbType.NVarChar, 50) { Value = familyName });
			}

			if (string.IsNullOrEmpty(commonName) == false)
			{
				where += " AND CommonName LIKE '%' + @CommonName + '%'";
				parameters.Add(new SqlParameter("@CommonName", System.Data.SqlDbType.NVarChar, 50) { Value = commonName });
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

			sql += " GROUP BY FamilyName, CommonName, Records.UserId "; 

			Func<SqlDataReader, GridDto> funcAssembler = reader =>
			{
				return new GridDto
				{
					UserId = reader.GetInt32("UserId", 0),
					FamilyName = reader.GetString("FamilyName"),
					CommonName = reader.GetString("CommonName"),
					Total = reader.GetInt32("Total", 0)
				};
			};

			return sqlDb.Search<GridDto>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public List<GridDto> TopThree(string locationName, string familyName, string commonName)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = @"SELECT TOP(3) WITH TIES　Records.UserId, FamilyName, CommonName, sum(Quantity)as Total
FROM Records
join Locations on Records.LocationId = Locations.LocationId
Join [dbo].[Species] on Species.SpeciesId = Records.SpeciesId";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(locationName) == false)
			{
				where += " AND LocationName LIKE '%' + @LocationName + '%'";
				parameters.Add(new SqlParameter("@LocationName", System.Data.SqlDbType.NVarChar, 50) { Value = locationName });
			}

			if (string.IsNullOrEmpty(familyName) == false)
			{
				where += " AND FamilyName LIKE '%' + @FamilyName + '%'";
				parameters.Add(new SqlParameter("@FamilyName", System.Data.SqlDbType.NVarChar, 50) { Value = familyName });
			}

			if (string.IsNullOrEmpty(commonName) == false)
			{
				where += " AND CommonName LIKE '%' + @CommonName + '%'";
				parameters.Add(new SqlParameter("@CommonName", System.Data.SqlDbType.NVarChar, 50) { Value = commonName });
			}

			
			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

			sql += " GROUP BY FamilyName, CommonName, Records.UserId ORDER BY sum(Quantity) DESC";

			Func<SqlDataReader, GridDto> funcAssembler = reader =>
			{
				return new GridDto
				{
					UserId = reader.GetInt32("UserId", 0),
					FamilyName = reader.GetString("FamilyName"),
					CommonName = reader.GetString("CommonName"),
					Total = reader.GetInt32("Total", 0)
				};
			};

			return sqlDb.Search<GridDto>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}
	}
}
