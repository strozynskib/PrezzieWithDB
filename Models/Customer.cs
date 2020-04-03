using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrezzieWithDB.Models
{
    public class Customer
    {
        [Key]
        public string userName { get; set; }
        public string countryUser { get; set; }

        //reference to Profile
        [Required]
        public virtual Profile profile { get; set; }
        public string eMail { get; set; }
    }
}