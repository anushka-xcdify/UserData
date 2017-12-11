using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usermanagement.Models.Entity.Users;

namespace usermanagement.Models.Users
{
    public interface IUserContactModel
    {
        List<UserContactEntity> Get();

        UserContactEntity Get(int id);

        bool Create(int userId, UserContactEntity user);

        bool Update(int uid, int id, UserContactEntity user);

        bool Delete(int id);
    }
}
