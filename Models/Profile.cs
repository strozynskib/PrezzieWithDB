using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrezzieWithDB.Models
{
    public class Profile
    {
        [Key]
        public string eMail { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string birthday { get; set; }
        public string descriptionUser { get; set; }

        //reference to Customer
        public virtual Customer customer { get; set; }
    }
}