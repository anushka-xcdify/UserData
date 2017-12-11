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
    public class UsersAddressController : ApiController
    {
        private IUserAddressModel userAddressModel;

        public UsersAddressController()
        {
            userAddressModel = new UsersAddressModel();
        }

        /// <summary>
        /// Web api for getting the list of users address
        /// </summary>
        /// <returns>A collection of users address.</returns>

         [Route("usersAddress")]
         [HttpGet]
        public List<UsersAddressEntity> Get()
        {
            return userAddressModel.Get();
        }

        /// <summary>
        /// Model methods for getting a particular user's address by ID
        /// </summary>
        /// <returns>A user's address details.</returns>
         
         [Route("usersAddress/{id}")]
         [HttpGet]
        public UsersAddressEntity Get(int id)
        {
            return userAddressModel.Get(id);
        }

        /// <summary>
        /// Model methods for creating new user address
        /// </summary>
        /// <returns>Boolean value verifies inserted or not.</returns>

          [Route("usersAddress/{userId}")]
          [HttpPost]
        public bool Post(int userId, [FromBody]UsersAddressEntity user)
        {
            return userAddressModel.Create(userId, user);
        }

        /// <summary>
        /// Model methods for updating user details
        /// </summary>
        /// <returns>Boolean value verifies updated or not.</returns>

          [Route("usersAddress/{userId}/{id}")]
          [HttpPut]
        public bool Put(int UserId, int id, [FromBody]UsersAddressEntity user)
        {
            return userAddressModel.Update(UserId, id, user);
        }

        /// <summary>
        /// Model methods for deleting a user address
        /// </summary>
        /// <returns>Boolean value verifies deleted or not.</returns>

         [Route("usersAddress/{id}")]
         [HttpDelete]
        public bool Delete(int id)
        {
            return userAddressModel.Delete(id);
        }
    }
}
