using AC.AvianExplorer.DataLayer.Cores;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Infra
{
	public class UserRepository : IUserRepository
	{
		public void Create(UserEntity entity)
		{
			string sql = "INSERT INTO Users (UserName, UserPwd) VALUES (@UserName, @UserPwd)";

			var parameter = SqlParameterBuilder.create()
				            .AddNvarchar("@UserName", 50, entity.UserName)
							.AddNvarchar("@UserPwd", 50, entity.UserPwd)
							.Build();

			sqlDb.Create(sqlDb.GetConnection, sql, parameter);
		}

		public UserEntity Get(int userId)
		{
			throw new NotImplementedException();
		}

		public UserEntity GetByName(string userName)
		{
			string sql = "SELECT * FROM Users WHERE UserName = @UserName";

			SqlParameter parameter = new SqlParameter("@UserName", System.Data.SqlDbType.NVarChar, 50) { Value = userName };

			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int UserId = reader.GetInt32("UserId", 0);
				string UserName = reader.GetString("UserName");
				string UserPwd = reader.GetString("UserPwd");
				return new UserEntity(UserName, UserPwd, UserId);
			};

			return sqlDb.Get<UserEntity>(sqlDb.GetConnection, funcAssembler, sql, parameter);
		}

		public List<UserEntity> Search(string userName, int? userId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = "SELECT * FROM Users";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(userName) == false)
			{
				where += " AND userName = @userName";
				parameters.Add(new SqlParameter("@userName", System.Data.SqlDbType.NVarChar, 50) { Value = userName });
			}

			if (userId.HasValue)
			{
				where += " AND id =" + userId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

			sql += " ORDER BY UserId";

			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("userId", 0);
				string name = reader.GetString("UserName");
				string pwd = reader.GetString("UserPwd");

				return new UserEntity(name, pwd, id);
			};

			return sqlDb.Search<UserEntity>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(UserEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
