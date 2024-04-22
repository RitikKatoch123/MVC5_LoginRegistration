using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Security;
using System.EnterpriseServices.Internal;
namespace MVC5_LoginRegistration.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed in the First Name field.")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed in the Last Name field.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "password is Required")]
        [DataType(DataType.Password)]
        //[StringLength(8, MinimumLength = 6, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage="Please confirm your password.")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }



    }
}