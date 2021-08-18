using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Range(100000,999999,ErrorMessage ="your employee id must be 6 digits")]
        [Display(Name ="Employee ID")]
        public int EmployeeId { get; set; }


        [Display(Name ="First Name")]
        [StringLength(250,MinimumLength =3,ErrorMessage ="your name must be at least 3 characters and above")]
        [Required(ErrorMessage ="you must specify your First Name")]
        public string FisrtName { get; set; }


        [Display(Name = "Last Name")]
        [StringLength(250,MinimumLength =3,ErrorMessage ="your last name must be at least 3 characters and above")]
        [Required(ErrorMessage = "you must specify your Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "you must specify your Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress",ErrorMessage ="Email Addresses must match")]
        public string ConfirmEmail { get; set; }


        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "you must specify your Password")]
        [StringLength(100,MinimumLength =6,ErrorMessage ="your passwrod must be atleast 6 digits")]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="your password must match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}