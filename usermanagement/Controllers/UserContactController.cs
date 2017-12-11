using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using usermanagement.Models.Entity.Users;
using usermanagement.Models.Users;

namespace usermanagement.Controllers
{
    [RoutePrefix("api")]
    public class UserContactController : ApiController
    {
        private IUserContactModel userContactModel;

        public UserContactController()
        {
            userContactModel = new UserContactModel();
        }

        /// <summary>
        /// Web api for getting the list of users address
        /// </summary>
        /// <returns>A collection of users address.</returns>

        [Route("usersContact")]
        [HttpGet]
        public List<UserContactEntity> Get()
        {
            return userContactModel.Get();
        }

        /// <summary>
        /// Model methods for getting a particular user's address by ID
        /// </summary>
        /// <returns>A user's address details.</returns>

        [Route("usersContact/{id}")]
        [HttpGet]
        public UserContactEntity Get(int id)
        {
            return userContactModel.Get(id);
        }

        /// <summary>
        /// Model methods for creating new user address
        /// </summary>
        /// <returns>Boolean value verifies inserted or not.</returns>

        [Route("usersContact/{userId}")]
        [HttpPost]
        public bool Post(int userId, [FromBody]UserContactEntity user)
        {
            return userContactModel.Create(userId, user);
        }

        /// <summary>
        /// Model methods for updating user details
        /// </summary>
        /// <returns>Boolean value verifies updated or not.</returns>

        [Route("usersContact/{userId}/{id}")]
        [HttpPut]
        public bool Put(int UserId, int id, [FromBody]UserContactEntity user)
        {
            return userContactModel.Update(UserId, id, user);
        }

        /// <summary>
        /// Model methods for deleting a user address
        /// </summary>
        /// <returns>Boolean value verifies deleted or not.</returns>

        [Route("usersContact/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return userContactModel.Delete(id);
        }
    }
}
