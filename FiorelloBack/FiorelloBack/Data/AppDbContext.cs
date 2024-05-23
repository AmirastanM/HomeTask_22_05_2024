using FiorelloBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);


            modelBuilder.Entity<Social>().HasData(
              new Social
              {
                  Id = 1,
                  Name = "Twitter",
                  Icon = "fab fa-twitter mr-1"                 
              },

                new Social
                {
                    Id = 2,
                    Name = "Instagram",
                    Icon = "fab fa-instagram mr-1"
                },
                  new Social
                  {
                      Id = 3,
                      Name = "Tumblr",
                      Icon = "fab fa-tumblr mr-1"
                  },
                   new Social
                   {
                       Id = 4,
                       Name = "Pinterest",
                       Icon = "fab fa-pinterest mr-1"
                   });



           modelBuilder.Entity<Setting>().HasData(
               new Setting
               {
                   Id = 1,
                   Key = "HeadeLogo",
                   Value = "logo.png",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now

               },
               new Setting
               {
                   Id = 2,
                   Key = "Phone",
                   Value = "994518579645",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now

               },
               new Setting
               {
                   Id = 3,
                   Key = "Address",
                   Value = "Ahmadli",
                   SoftDeleted = false,
                   CreatedDate = DateTime.Now

               });


            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Titel = "Titel1",
                    Description = "Reshadin blogu",
                    Image = "blog-feature-img-1.jpg",
                    CreatedDate = DateTime.Now

                },
                new Blog
                {
                    Id = 2,
                    Titel = "Titel2",
                    Description = "Ilgarin blogu",
                    Image = "blog-feature-img-3.jpg",
                    CreatedDate = DateTime.Now

                },
                new Blog
                {
                    Id = 3,
                    Titel = "Titel3",
                    Description = "Hacixanin blogu",
                    Image = "blog-feature-img-4.jpg",
                    CreatedDate = DateTime.Now

                });
       
        }
    }
}
