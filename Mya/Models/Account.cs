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
        public string UserId { get; set; }

        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Display(Name = "用户密码")]
        public string UserPwd { get; set; }

        [Display(Name = "用户性别")]
        public string UserSex { get; set; }

        [Display(Name = "用户邮箱")]
        public string UserEmail { get; set; }

        [Display(Name = "用户权限")]
        public string UserRole { get; set; }
    }
}
