using AC.AvianExplorer.DataLayer.Cores;
using AC.AvianExplorer.DataLayer.Dtos;
using AC.AvianExplorer.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.UserServices
{
	public class UserService
	{
		private readonly IUserRepository _repo;

		public UserService(IUserRepository repo) { _repo = repo; }
		public bool IsValid(string userName, string UserPwd)
		{

			// precondition checks
			// account, password 必填
			if (string.IsNullOrEmpty(userName)) { throw new ArgumentNullException(nameof(userName), "帳號必填"); }
			if (string.IsNullOrEmpty(UserPwd)) { throw new ArgumentNullException(nameof(UserPwd), "密碼必填"); }

			//取得單一使用者
			UserEntity user = _repo.GetByName(userName);
			if (user == null) { return false; }

			//判斷密碼是否正確
			string passwordInDb = user.UserPwd;//這是正確的密碼

			//如果不拘大小寫
			return (passwordInDb.ToLower() == UserPwd.ToLower());

			//如果要區分大小寫
			//passwordInDb == password;
		}

		public void Create(UserAddDto dto)
		{
			//檢查name是否已存在
			var data = _repo.Search(dto.UserName, null);
			if (data != null && data.Count > 0) throw new Exception("分類名稱已存在");

			//若名稱唯一，允許新建紀錄
			UserEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}

	    public UserEntity GetByName(string userName)
		{
			return _repo.GetByName(userName);
		}
	}
}
