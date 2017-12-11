using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using usermanagement.Models.Entity.Users;

namespace usermanagement.Models.Users
{
    public interface IUsersModel
    {
        List<UsersEntity> Get();

        UsersEntity Get(int id);

        bool Create(UsersEntity usersEntity);

        bool Update(int id, UsersEntity usersEntity);

        bool Delete(int id);
    }
}