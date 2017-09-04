using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheProject.Models
{
    public class UserAccount
    {
        //Use Key to make UserId as a primary key in the database.
        [Key]
        public int UserId { get; set; }

        public int Admin { get; set; }

        //Use Required on the fields that need to be filled out or it will make a Errormessage.
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public int Password { get; set; }

        [Compare("Password", ErrorMessage = "Password not match.")]
        [DataType(DataType.Password)]
        public int ConfirmPassword { get; set; }
    }
}


 