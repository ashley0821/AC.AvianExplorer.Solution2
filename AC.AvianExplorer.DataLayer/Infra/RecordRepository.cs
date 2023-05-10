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
	public class RecordRepository : IRecordRepository
	{
		public void Create(RecordAddDto dto)
		{
			throw new NotImplementedException();
		}

		public void Delete(int recordId)
		{
			throw new NotImplementedException();
		}

		public RecordEditDto Get(int recordId)
		{
			string sql = @"SELECT RecordId,records.UserId, LocationName ,FamilyName, CommonName, RecordTime, Quantity 
FROM Records
join Locations on Records.LocationId = Locations.LocationId
Join [dbo].[Species] on Species.SpeciesId = Records.SpeciesId
WHERE RecordId = " + recordId;

			Func<SqlDataReader, RecordEditDto> funcAssembler = reader =>
			{
				return new RecordEditDto
				{
					RecordId = recordId,
					UserId = reader.GetInt32("UserId", 0),
					LocationName = reader.GetString("LocationName"),
					FamilyName = reader.GetString("FamilyName"),
					CommonName = reader.GetString("CommonName"),
					RecordTime = reader.GetDateTime("RecordTime", DateTime.MinValue),
					Quantity = reader.GetInt32("Quantity", 0)
				};
			};

			return sqlDb.Get<RecordEditDto>(sqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<RecordDto> Search(string locationName, string familyName, string commonName, int? recordId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = @"SELECT RecordId,records.UserId, LocationName ,FamilyName, CommonName, RecordTime, Quantity 
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

			if (recordId.HasValue)
			{
				where += " AND RecordId =" + recordId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

			sql += " ORDER BY RecordId"; //再看看

			Func<SqlDataReader, RecordDto> funcAssembler = reader =>
			{
				return new RecordDto
				{
					RecordId = reader.GetInt32("RecordId", 0),
					UserId = reader.GetInt32("UserId", 0),
					LocationName = reader.GetString("LocationName"),
					FamilyName = reader.GetString("FamilyName"),
					CommonName = reader.GetString("CommonName"),
					RecordTime = reader.GetDateTime("RecordTime", DateTime.MinValue),
					Quantity = reader.GetInt32("Quantity", 0)
	            };
			};

			return sqlDb.Search<RecordDto>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(RecordEditDto dto)
		{
			throw new NotImplementedException();
		}
	}
}
