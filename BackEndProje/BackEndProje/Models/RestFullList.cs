using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Models
{
    public class RestFullList
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile FilaImage { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [ForeignKey("AboutRestaurant")]
        public int AboutRestaurantId { get; set; }
        public AboutRestaurant AboutRestaurant { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("ContactInfo")]
        public int ContactInfoId { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public List<Pricing> Pricings { get; set; }


    }
}
