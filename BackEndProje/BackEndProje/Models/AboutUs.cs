using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        IFormFile FileImage { get; set; }
        [MaxLength(20)]
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string Content { get; set; }
        [MaxLength(500)]
        public string Link { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
