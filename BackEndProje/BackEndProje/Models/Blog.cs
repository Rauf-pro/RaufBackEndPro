using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile FileImage { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
