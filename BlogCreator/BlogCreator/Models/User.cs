using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCreator.Models
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Required")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Emai is not valid")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Required")]
        public string Phone { get; set; }

        [Display(Name = "Avatar")]
        public string Avatar { get; set; }

        public virtual ICollection <Blog> Blogs { get; set; }

    }
}
