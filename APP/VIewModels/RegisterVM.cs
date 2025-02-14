﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APP.ViewModels
{
    public class RegisterVM
    {
        [Required, EmailAddress]
        [Remote(action:"IsEmailUsed",controller:"Account")]
        public string Email { get; set; }

        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and confirmation password did not match.")]
        public string ConfirmPassword { get; set; }
    }
}
