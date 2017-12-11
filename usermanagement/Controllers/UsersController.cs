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
    public class UsersController : ApiController
    {
        private IUsersModel usersModel;

        public UsersController()
        {
            usersModel = new UsersModel();
        }

        /// <summary>
        /// Web api for getting the list of users
        /// </summary>
        /// <returns>A collection of users.</returns>

        [Route("users")]
        [HttpGet]
        public List<UsersEntity> Get()
        {
            return usersModel.Get();
        }

        /// <summary>
        /// Model methods for getting a particular user by ID
        /// </summary>
        /// <returns>A user details.</returns>

        [Route("users/{id}" )]
        [HttpGet]
        public UsersEntity Get(int id)
        {
            return usersModel.Get(id);
        }

        /// <summary>
        /// Model methods for creating new user
        /// </summary>
        /// <returns>Boolean value verifies inserted or not.</returns>

        [Route("users")]
        [HttpPost]
        public bool Post([FromBody]UsersEntity user)
        {
            return usersModel.Create(user);
        }

        /// <summary>
        /// Model methods for deleting a user
        /// </summary>
        /// <returns>Boolean value verifies deleted or not.</returns>

        [Route("users/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return usersModel.Delete(id);
        }

        /// <summary>
        /// Model methods for updating user details
        /// </summary>
        /// <returns>Boolean value verifies updated or not.</returns>

        [Route("users/{id}")]
        [HttpPut]
        public bool Put(int id, UsersEntity user)
        {
            return usersModel.Update(id, user);
        }

    }
}
