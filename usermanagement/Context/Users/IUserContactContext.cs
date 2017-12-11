using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usermanagement.Models.Entity.Users;


namespace usermanagement.Context.Users
{
    public interface IUserContactContext
    {
        List<UserContactEntity> Get();

        UserContactEntity Get(int id);

        bool Create(int id, UserContactEntity user);

        bool Delete(int id);

        bool Update(int UserId, int id, UserContactEntity user);

    }
}
