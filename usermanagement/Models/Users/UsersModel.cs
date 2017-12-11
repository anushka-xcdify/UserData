using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using usermanagement.Context.Users;
using usermanagement.Models.Entity.Users;

namespace usermanagement.Models.Users
{
    /// <summary>
    /// User model for
    /// </summary>
    public class UsersModel : IUsersModel
    {
        IUsersContext usersContext;
        public UsersModel()
        {
            usersContext = new UsersContext();
        }

        /// <summary>
        /// Model methods for getting the list of users
        /// </summary>
        /// <returns>A collection of users.</returns>
        public List<UsersEntity> Get()
        {
            return usersContext.Get();
        }

        /// <summary>
        /// Model methods for getting a particular user by ID
        /// </summary>
        /// <returns>A user details.</returns>

        public UsersEntity Get(int id)
        {
            return usersContext.Get(id);
        }

        /// <summary>
        /// Model methods for creating new user
        /// </summary>
        /// <returns>Boolean value verifies inserted or not.</returns>
       
        public bool Create(UsersEntity usersEntity)
        {
            return usersContext.Create(usersEntity);
        }

        /// <summary>
        /// Model methods for deleting a user
        /// </summary>
        /// <returns>Boolean value verifies deleted or not.</returns>
        
        public bool Delete(int id)
        {
            return usersContext.Delete(id);
        }

        /// <summary>
        /// Model methods for updating user details
        /// </summary>
        /// <returns>Boolean value verifies updated or not.</returns>

        public bool Update(int id, UsersEntity usersEntity)
        {
            return usersContext.Update(id, usersEntity);
        }
    }
}