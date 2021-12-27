using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class AboutRestaurant
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public List<RestFullList> RestFullLists { get; set; }
    }
}
