using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace riot.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name="Fisrt Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Birthday")]
        public DateTime BirthDate { get; set; }

        public string Region { get; set; }
    }
}
