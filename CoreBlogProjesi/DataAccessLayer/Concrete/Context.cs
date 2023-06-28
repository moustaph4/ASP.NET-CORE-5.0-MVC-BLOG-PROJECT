using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{

    // Context sınıfı DbContext sınıfından türetilip, sql bağlantısını yaptığımız sınıftır.
    
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder kullanarak veri tabanımızı bağladık.
            optionsBuilder.UseSqlServer("server=MUSTAFA-LAPTOP; database=dbCoreBlog; integrated security= true;");
        }


        // DbContext sınıfının DbSet türünden oluşturduğumuz nesneler veri tabanımızda tabloları oluşturur.
        
        // Örneğin veri tabanımızda Abouts adında bir tablo oluştu ve içinde About sınıfındaki alanlardan nesneler oluştu. 
        // Örneğin veri tabanımızda Abouts adında bir tablo oluştu ve içinde About sınıfındaki alanlardan nesneler oluştu. 

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

        
    }
}
