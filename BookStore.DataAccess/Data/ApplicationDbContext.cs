using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Investing", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Inspirational", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Thriller", DisplayOrder = 6 }


                );
            modelBuilder.Entity<Company>().HasData(

                    new Company
                              {
                                  Id = 1,
                                  Name = "Ink & Ideas Publishing",
                                  StreetAddress = "210 Penrose Lane",
                                  City = "Literaria",
                                  PostalCode = "45678",
                                  State = "WA",
                                  PhoneNumber = "8001234567"
                              },
                new Company
                {
                    Id = 2,
                    Name = "The Book Nook",
                    StreetAddress = "74 Whispering Pages Dr",
                    City = "Bookford",
                    PostalCode = "90210",
                    State = "OR",
                    PhoneNumber = "8339876543"
                },
                new Company
                {
                    Id = 3,
                    Name = "NovelNest Inc.",
                    StreetAddress = "159 Spine Street",
                    City = "Pagetown",
                    PostalCode = "30303",
                    State = "GA",
                    PhoneNumber = "8773210987"
                },
                new Company
                {
                    Id = 4,
                    Name = "Chapters & Co.",
                    StreetAddress = "12 Leaf Blvd",
                    City = "Readmore",
                    PostalCode = "60606",
                    State = "IL",
                    PhoneNumber = "8664443322"
                },
                new Company
                {
                    Id = 5,
                    Name = "FictionFlow",
                    StreetAddress = "88 Prose Path",
                    City = "Verseville",
                    PostalCode = "75001",
                    State = "TX",
                    PhoneNumber = "8445556677"
                }

               );
          

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "The Hunger Games",
                     Author = "Suzanne Collins",
                     Description = "A gripping dystopian action‑adventure novel known for high-stakes plotting and strong pacing — ideal for the action genre.",
                     ISBN = "9780439023528",
                     ListPrice = 120,
                     Price = 110,
                     Price50 = 105,
                     Price100 = 100,
                     CategoryId = 1, // Action
                     ImageUrl = ""
                 },
                new Product
                {
                    Id = 2,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Description = "Epic world‑building, political intrigue, and interstellar conflict make this one of the most celebrated sci-fi novels ever.",
                    ISBN = "9780441172719",
                    ListPrice = 150,
                    Price = 140,
                    Price50 = 135,
                    Price100 = 130,
                    CategoryId = 2, // Sci-Fi
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "The Lives of the Caesars",
                    Author = "Suetonius (translated by Tom Holland)",
                    Description = "A historical classic recounting the lives and scandals of Roman emperors — both informative and highly readable.",
                    ISBN = "9780141399209",
                    ListPrice = 110,
                    Price = 100,
                    Price50 = 95,
                    Price100 = 90,
                    CategoryId = 3, // History
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "The Intelligent Investor",
                    Author = "Benjamin Graham",
                    Description = "Considered the definitive guide to value investing, favored by professionals and finance students alike.",
                    ISBN = "9780060555665",
                    ListPrice = 130,
                    Price = 120,
                    Price50 = 115,
                    Price100 = 110,
                    CategoryId = 4, // Investing
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Take Less, Do More",
                    Author = "Glen Van Peski",
                    Description = "Winner of the 2025 Inspirational IBPA Book Award, this memoir offers practical motivation and personal growth perspectives.",
                    ISBN = "9781637632895",
                    ListPrice = 100,
                    Price = 95,
                    Price50 = 90,
                    Price100 = 85,
                    CategoryId = 5, // Inspirational
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "The Intruder",
                    Author = "Daniel Hurst",
                    Description = "A psychological thriller with unexpected twists and mounting suspense — fitting for readers seeking edge-of-the-seat tension.",
                    ISBN = "9781837560103",
                    ListPrice = 115,
                    Price = 105,
                    Price50 = 100,
                    Price100 = 95,
                    CategoryId = 6, // Thriller
                    ImageUrl = ""
                }


        );
        }
    }
}
