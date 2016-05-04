using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DAL.Models
{
    public class SavedImage
    {
        [Key]
        public int ImageID { get; set; }
        [Required]
        public string FileName { get; set; }
    }
}
