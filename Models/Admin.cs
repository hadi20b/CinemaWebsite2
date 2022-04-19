﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_Website.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="please enter your first name")]
        [StringLength(maximumLength:20,MinimumLength =3,ErrorMessage ="First Name should be between 20-3 char")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "please enter your last name")]
        [StringLength(maximumLength:20,MinimumLength =3)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "please enter your email address")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Password,ErrorMessage = "Invalid Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The Password and confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        public string phoneNumber { get; set; }

        //Navigation
        public ICollection<Movie> Movies { get; set; }

    }
}
