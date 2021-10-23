using CommunitiApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace CommunitiApp.Models
{
    public class SystemUser
    {
        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string NameSurname { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime LastLogin { get; set; }
        public UserState UserState { get; set; }
        public bool IsDeleted { get; set; }


        public bool Login()
        {
            return true;
        }
        public bool logout()
        {
            return true;
        }
        public bool active()
        {
            return true;
        }
        public int Save()
        {
            return 1;
        }
        public bool Delete()
        {
            return true;
        }
        /// <summary>
        /// Returns list of users 
        /// </summary>
        /// <param name="filter">Filter keyword</param>
        /// <returns>Returns a generic list of users filtered by parameter</returns>
        public List<SystemUser> Getlist(string filter)
        {
            return new List<SystemUser>();
        }

    }

}
