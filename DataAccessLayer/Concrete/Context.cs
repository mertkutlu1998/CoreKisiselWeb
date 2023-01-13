using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-M94S501\\SQLEXPRESS;database=CoreWebProjeDb;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; } //Hakkımda
        public DbSet<Contact> Contacts { get; set; } //İletişim
        public DbSet<Experience> Experiences { get; set; } //Deneyimler
        public DbSet<Feature> Features { get; set; } //Özellikler
        public DbSet<Message> Messages { get; set; } //Mesaj
        public DbSet<Portfolio> Portfolios { get; set; } //Portöyler
        public DbSet<Service> Services { get; set; } //Hizmetler
        public DbSet<Skill> Skills { get; set; } //Yetenekler
        public DbSet<SocialMedia> SocialMedias { get; set; } //Sosyal Medya
        public DbSet<Testimonial> Testimonials { get; set; } //Referanslar
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
