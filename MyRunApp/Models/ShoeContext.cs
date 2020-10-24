using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MyRunApp.Models
{
    public class ShoeContext : DbContext
    {
        public ShoeContext(DbContextOptions<ShoeContext> options) : base(options) { }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = "B", Name = "Blue" },
                  new Color { ColorId = "P", Name = "Pink" },
                  new Color { ColorId = "G", Name = "Green" },
                   new Color { ColorId = "O", Name = "Orange" },
                    new Color { ColorId = "Y", Name = "Yellow" },
                    new Color { ColorId = "M", Name = "Multi" }
            );

            modelBuilder.Entity<Shoe>().HasData(
                new Shoe
                {
                    ShoeId = 1,
                    Brand = "Brooks",
                    Name = "Ghost 13",
                    Use = "Road Running",
                    Support= "Neutral",
                    ColorId="B"
                    
                },
                  new Shoe
                  {
                      ShoeId = 2,
                      Brand = "Hoka",
                      Name = "Tennine",
                      Use = "Trail Running",
                      Support = "Stability",
                      ColorId = "M"

                  },
                  new Shoe
                  {
                      ShoeId =31,
                      Brand = "Saucany",
                      Name = "Triumph 17 LE",
                      Use = "Road Running",
                      Support = "Neutral",
                      ColorId = "O"

                  }

                );
        }
    }
}


