using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usermanagement.Models.Entity.Users;

namespace usermanagement.Context.Users
{
    /// <summary>
    /// 
    /// </summary>
   public interface IUsersContext
    {
        List<UsersEntity> Get();

        UsersEntity Get(int id);

        bool Create(UsersEntity usersEntity);

        bool Update(int id, UsersEntity usersEntity);

        bool Delete(int id);
    }
}
