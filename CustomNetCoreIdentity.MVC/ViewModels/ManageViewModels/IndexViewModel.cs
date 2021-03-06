﻿using System.ComponentModel.DataAnnotations;

namespace CustomNetCoreIdentity.MVC.ViewModels.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
