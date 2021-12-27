using BackEndProje.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.DATA
{
    public class AppDbContext:IdentityDbContext
        
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<WorkingProsses> WorkingProsses { get; set; }
        public DbSet<RestFullList> RestFullLists { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AboutRestaurant> AboutRestaurants { get; set; }


    }
}
