using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace usermanagement.Models.Entity.Users
{
    /// <summary>
    /// Entity for user address.
    /// </summary>
    
    public class UsersAddressEntity
    {
        private int userID;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string country;
        private int zip;
        private bool primaryAddress;

        /// <summary>
        /// Get or Set UserID
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// Get or Set Address1
        /// </summary>
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        /// <summary>
        /// Get or Set Address2
        /// </summary>
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        /// <summary>
        /// Get or Set City
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Get or Set State
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Get or Set Country
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// Get or Set Zip code
        /// </summary>
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        /// <summary>
        /// Get or Set Primary address
        /// </summary>
        public bool PrimaryAddress
        {
            get { return primaryAddress; }
            set { primaryAddress = value; }
        }
    }
}