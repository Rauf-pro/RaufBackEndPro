using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class WorkingProsses
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Icon { get; set; }
        public int Count { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
