using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCreator.Models
{
    public class Comment
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CommentId { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Required")]
        public string CommentDescription { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Required")]
        public string UserName { get; set; }

        [Required]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
