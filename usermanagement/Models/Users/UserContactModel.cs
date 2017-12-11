using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using usermanagement.Context.Users;
using usermanagement.Models.Entity.Users;


namespace usermanagement.Models.Users
{
    public class UserContactModel : IUserContactModel
    {
        /// <summary>
        /// Model for User address
        /// </summary>

        IUserContactContext userContactContext;

        public UserContactModel()
        {
            userContactContext = new UserContactContext();
        }

        /// <summary>
        /// Model methods for getting the list of users address
        /// </summary>
        /// <returns>A collection of users address.</returns>
        public List<UserContactEntity> Get()
        {
            return userContactContext.Get();
        }

        /// <summary>
        /// Model methods for getting a particular user address by ID
        /// </summary>
        /// <returns>A user address details.</returns>
        public UserContactEntity Get(int id)
        {
            return userContactContext.Get(id);
        }

        /// <summary>
        /// Model methods for creating new user address
        /// </summary>
        /// <returns>Boolean value verifies inserted or not.</returns>
        public bool Create(int userId, UserContactEntity user)
        {
            return userContactContext.Create(userId, user);
        }

        /// <summary>
        /// Model methods for deleting a user address
        /// </summary>
        /// <returns>Boolean value verifies deleted or not.</returns>
        public bool Delete(int id)
        {
            return userContactContext.Delete(id);
        }

        /// <summary>
        /// Model methods for updating user address details
        /// </summary>
        /// <returns>Boolean value verifies updated or not.</returns>
        public bool Update(int uid, int id, UserContactEntity user)
        {
            return userContactContext.Update(uid, id, user);
        }
    }
}