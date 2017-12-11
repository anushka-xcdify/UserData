using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using usermanagement.Models.Entity.Users;

namespace usermanagement.Mapper.Users
{
    public class UsersMapper
    {
        public UsersEntity mapUsers(SqlDataReader dr)
        {
            return new UsersEntity()
            {
                UserID = dr.GetString(1),
                FirstName = dr.GetString(2),
                LastName = dr.GetString(3),
                Gender = dr.GetString(4),
                DOB = Convert.ToDateTime(dr[5]),
                IsActive = dr.GetBoolean(6),
                CreateDate = Convert.ToDateTime(dr[7])
            };
        }
    }
}