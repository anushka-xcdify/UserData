using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace usermanagement.Models.Entity.Users
{
    /// <summary>
    /// Entity for user.
    /// </summary>
    public class UsersEntity
    {

        #region private pro
        private string userID;
        private string firstName;
        private string lastName;
        private DateTime dOB;
        private string gender;
        private bool isActive;
        private DateTime createDate;

        #endregion


        /// <summary>
        /// Get or Set userid
        /// </summary>
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// Get or Set firstname
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Get or Set lastname
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Get or Set isActive
        /// </summary>
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        /// <summary>
        /// Get or Set DOB
        /// </summary>
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

        /// <summary>
        /// Get or Set CreateDate
        /// </summary>
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }



        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }


       


       


       
    }
}