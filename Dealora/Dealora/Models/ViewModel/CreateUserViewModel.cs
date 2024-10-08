﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dealora.Models;

namespace Dealora.ViewModels
{
    public class CreateUserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
        public string Password { get; set; }

        [Display(Name = "Mobile No.(Optional)")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(20, ErrorMessage = "Phone Number cannot be longer than 20 characters")]
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }

    }
}
