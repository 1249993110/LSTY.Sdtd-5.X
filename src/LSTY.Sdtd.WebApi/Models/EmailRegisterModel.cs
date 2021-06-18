﻿using IceCoffee.AspNetCore.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSTY.Sdtd.WebApi.Models
{
    public class EmailRegisterModel
    {
        [Required(ErrorMessage = DataAnnotationsResource.RequiredAttribute_ValidationError)]
        public string AccountName { get; set; }

        [Required(ErrorMessage = DataAnnotationsResource.RequiredAttribute_ValidationError)]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = DataAnnotationsResource.RequiredAttribute_ValidationError)]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = DataAnnotationsResource.RequiredAttribute_ValidationError)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = DataAnnotationsResource.RequiredAttribute_ValidationError)]
        public string VerificationCode { get; set; }
    }
}
