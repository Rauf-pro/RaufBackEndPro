using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string SubTitle { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("RestFullList")]
        public int RestFullListId { get; set; }
        public RestFullList RestFullList { get; set; }
    }
}
