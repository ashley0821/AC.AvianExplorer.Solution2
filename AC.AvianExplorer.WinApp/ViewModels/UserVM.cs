using AC.AvianExplorer.DataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.WinApp.ViewModels
{
	public class UserVM
	{
        public int UserId { get; set; }
		public string UserName { get; set; }
        public string UserPwd { get; set; }
    }

	public static class UserDtoExts
	{
		public static UserVM ToViewModel(this UserDto dto)
		{
			return new UserVM
			{
				UserId = dto.UserId,
				UserName = dto.UserName,
				UserPwd = dto.UserPwd,
			};
		}
	}

	public class UserAddVM
	{
		public string UserName { get; set; }
		public string UserPwd { get; set; }
	}

	public static class UserAddVMExts
	{
		public static UserAddDto ToDto(this UserAddVM vm)
		{
			return new UserAddDto
			{
				UserName = vm.UserName,
				UserPwd = vm.UserPwd
			};
		}
	}

	public class UserEditVM
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string UserPwd { get; set; }
	}

	public static class UserEditVMExts
	{
		public static UserEditDto ToDto(this UserEditVM vm)
		{
			return new UserEditDto
			{
				UserId = vm.UserId,
				UserName = vm.UserName,
				UserPwd = vm.UserPwd
			};
		}

		public static UserEditVM ToViewModel(this UserEditDto dto)
		{
			return new UserEditVM
			{
				UserId = dto.UserId,
				UserName = dto.UserName,
				UserPwd = dto.UserPwd,
			};
		}
	}
}
