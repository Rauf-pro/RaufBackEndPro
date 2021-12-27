using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string LocAddress { get; set; }
        public List<RestFullList> RestFullLists { get; set; }
    }
}
