using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Cores
{
	public class UserEntity
	{
		public int UserId { get; private set; }
		public string UserName { get; private set; }
		public string UserPwd { get; private set; }

		public UserEntity(string UserName, string UserPwd, int UserId = 0)
		{
			//todo 在這裡，檢查各傳入值的正確性

			this.UserId = UserId;
			this.UserName = UserName;
			this.UserPwd = UserPwd;
		}
	}
}
