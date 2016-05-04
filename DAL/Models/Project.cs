using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public string Title { get; set; }
        public SavedImage Avatar { get; set; }
        public string Descriotion { get; set; }
        public List<SavedImage> ImagesInProject { get; set; }
        public string ProjectURL { get; set; }
    }
}
