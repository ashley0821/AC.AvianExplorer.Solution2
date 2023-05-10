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
	public class LocationRepository : ILocationRepository
	{
		public void Create(LocationAddDto dto)
		{
			string sql = "INSERT INTO Locations (LocationName, UserId) VALUES(@LocationName, @UserId)";

			var parameter = SqlParameterBuilder.create()
				.AddNvarchar("@LocationName", 20, dto.LocationName)
				.AddInt("@UserId", dto.UserId)
				.Build();

			sqlDb.Create(sqlDb.GetConnection, sql, parameter);
		}

		public void Delete(int locationId)
		{
			string sql = "DELETE FROM Locations WHERE LocationId = " + locationId ;


			sqlDb.UpdateOrDelete(sqlDb.GetConnection, sql, null);
		}

		public LocationDto Get(int locationId)
		{
			string sql = "SELECT * FROM Locations WHERE LocationId = " + locationId ;

			Func<SqlDataReader, LocationDto> funcAssembler = reader =>
			{
				return new LocationDto
				{
					LocationId = reader.GetInt32("LocationId", 0),
					LocationName = reader.GetString("LocationName"),
					UserId = reader.GetInt32("UserId", 0)
				};
			};

			return sqlDb.Get<LocationDto>(sqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<LocationDto> Search(string locationName, int? locationId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = "SELECT * FROM Locations";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(locationName) == false)
			{
				where += " AND LocationName like '%' + @LocationName + '%'";
				parameters.Add(new SqlParameter("@LocationName", System.Data.SqlDbType.NVarChar, 50) { Value = locationName });
			}

			if (locationId.HasValue)
			{
				where += " AND id =" + locationId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

			sql += " ORDER BY LocationId";

			Func<SqlDataReader, LocationDto> funcAssembler = reader =>
			{
				return new LocationDto
				{
					LocationId = reader.GetInt32("LocationId", 0),
					LocationName = reader.GetString("LocationName"),
					UserId = reader.GetInt32("UserId", 0)
				};
			};

			return sqlDb.Search<LocationDto>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(LocationEditDto dto)
		{
			string sql = "UPDATE Locations SET LocationName = @LocationName WHERE LocationId = @LocationId";

			var parameters = SqlParameterBuilder.create()
							 .AddInt("@LocationId", dto.LocationId)
							 .AddNvarchar("@LocationName", 50, dto.LocationName)
							 .Build();

			sqlDb.UpdateOrDelete(sqlDb.GetConnection, sql, parameters);
		}
	}
}
