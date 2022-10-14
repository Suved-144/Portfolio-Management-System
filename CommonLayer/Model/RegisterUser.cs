using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_System.Model
{
    public class UserDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class RegisterUserResquest
    {
        [Required(ErrorMessage = "UserName Is Mandetory")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Is Mandetory")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword Is Mandetory")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterUserResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
