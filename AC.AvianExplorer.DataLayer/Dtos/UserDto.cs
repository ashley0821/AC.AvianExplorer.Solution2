using AC.AvianExplorer.DataLayer.Cores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Dtos
{
	public class UserDto
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string UserPwd { get; set; }
	}

	public static class UserEntityExts
	{
		public static UserDto ToDto(this UserEntity entity)
		{
			return new UserDto
			{
				UserId = entity.UserId,
				UserName = entity.UserName,
				UserPwd = entity.UserPwd,
			};
		}
	}

	public class UserAddDto
	{
		public string UserName { get; set; }
		public string UserPwd { get; set; }
	}

	public static class UserAddDtoExts
	{
		public static UserEntity ToEntity(this UserAddDto dto)
		{
			return new UserEntity(dto.UserName, dto.UserPwd);
		}
	}

	public class UserEditDto
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string UserPwd { get; set; }
	}

	public static class UserEditDtoExts
	{
		public static UserEditDto ToEditDto(this UserEntity entity)
		{
			return new UserEditDto
			{
				UserId = entity.UserId,
				UserName = entity.UserName,
				UserPwd = entity.UserPwd
			};
		}

		public static UserEntity ToEntity(this UserEditDto dto)
		{
			return new UserEntity(dto.UserName, dto.UserPwd, dto.UserId);
		}
	}
}
