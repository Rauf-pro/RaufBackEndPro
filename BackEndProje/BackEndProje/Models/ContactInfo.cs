using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class ContactInfo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string ReceptPhone { get; set; }
        [MaxLength(50)]
        public string ComplantPhone { get; set; }
        [MaxLength(50)]
        public string SupportPhone { get; set; }
        public List<RestFullList> RestFullLists { get; set; }
    }
}