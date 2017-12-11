using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usermanagement.Models.Entity.Users;

namespace usermanagement.Models.Users
{
   public interface IUserAddressModel
    {
        List<UsersAddressEntity> Get();

        UsersAddressEntity Get(int id);

        bool Create(int userId, UsersAddressEntity user);

        bool Update(int uid, int id, UsersAddressEntity user);

        bool Delete(int id);
    }
}
