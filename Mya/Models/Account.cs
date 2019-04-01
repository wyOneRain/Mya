using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mya.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Display(Name = "用户ID")]
        public string userId { get; set; }

        [Display(Name = "用户名")]
        public string userName { get; set; }

        [Display(Name = "用户密码")]
        public string userPwd { get; set; }

        [Display(Name = "用户性别")]
        public string userSex { get; set; }

        [Display(Name = "用户邮箱")]
        public string userEmail { get; set; }

        [Display(Name = "用户权限")]
        public string userRole { get; set; }
    }
}
