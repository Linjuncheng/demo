using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InvoiceSystem.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "账号")]
        [EmailAddress]
        public string LoginTel { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "记住我?")]
        public bool RememberMe { get; set; }

    }
}