using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace usermanagement.Models.Entity.Users
{
    /// <summary>
    /// Entity for user contact.
    /// </summary>
    
    public class UserContactEntity
    {
        private int userID;
        private string contacttype;
        private string contactvalue;
        private bool primarycontact;

        /// <summary>
        /// Get or Set UserID
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// Get or Set contac type
        /// </summary>
        public string ContactType
        {
            get { return contacttype; }
            set { contacttype = value; }
        }

        /// <summary>
        /// Get or Set contact value
        /// </summary>
        public string ContactValue
        {
            get { return contactvalue; }
            set { contactvalue = value; }
        }

        /// <summary>
        /// Get or Set Primary contact
        /// </summary>
        public bool PrimaryContact
        {
            get { return primarycontact; }
            set { primarycontact = value; }
        }
    }
}