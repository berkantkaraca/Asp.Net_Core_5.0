using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //veritabanı bağlantı stringini ve veritabanı tablolarını tutar
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BKARACA\\SQLEXPRESS; database=CoreProjeDB; integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; } // verilen isim veritabanındaki tablo ismi olmalı
        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<Experience> Experiences { get; set; } 
        public DbSet<Feature> Features { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Portfolio> Portfolios { get; set; } 
        public DbSet<Service> Services { get; set; } 
        public DbSet<Skill> Skills { get; set; } 
        public DbSet<SocialMedia> SocialMedias { get; set; } 
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }

        //Migration yaparken Package Manager Console da:
        //                           proje olarak DataAccesLayer seç ve add-migration mig1 yaz.
        //                           Sonra update-database yaz

    }
}
