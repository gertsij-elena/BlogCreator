using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCreator.Models
{
    public class Blog
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BlogId { get; set; }

        [Display(Name = "Short Description")]
        [Required(ErrorMessage = "Required")]       
        public string BlogName { get; set; }

        [Display(Name = "Long Description")]
        [Required(ErrorMessage = "Required")]       
        public string BlogDescription { get; set; }

        [Display(Name = "Thema")]
        [Required(ErrorMessage = "Поле обязательно")]
        public string SectionsName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Data Add")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm:ss}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
