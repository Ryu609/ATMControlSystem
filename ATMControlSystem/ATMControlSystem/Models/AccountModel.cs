using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATMControlSystem.Models
{
    public class AccountModel
    {
        [Required]
        [Display(Name = "Acount Number")]
        [EmailAddress]
        public string AccNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        
    }
}