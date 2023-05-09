using AC.AvianExplorer.DataLayer.Cores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Interfaces
{
	public interface IUserRepository
	{
		void Create(UserEntity entity);
		void Update(UserEntity entity);
		UserEntity Get(int userId);
		UserEntity GetByName(string userName);

		List<UserEntity> Search(string userName, int? userId);
	}
}
