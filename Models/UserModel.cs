using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebAppRoutingHelpers.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppRoutingHelpers.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter Username")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please Enter Contact Number")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Please Enter Correct Contact No.")]
        public string Contact { get; set; }


        [Required(ErrorMessage = "Please Select Country Name")]
        public string Country { get; set; }


        [Required(ErrorMessage = "Please Select City Name")]
        public string City { get; set; }


        [Required(ErrorMessage = "Please select Gender.")]
        public string Gender { get; set; }

        [ValidateCheckbox(ErrorMessage = "Please Accept Terms.")]
        [Display(Name = "Accept Terms")]
        public bool Terms { get; set; }

    }

    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }
    }

    public class City
    {
        public int CountryId { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }
    }


}
