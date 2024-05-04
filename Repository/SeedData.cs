using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            {
                _context.Product.AddRange(

                    new ProductModel { Name = "Vì sao thế nhỉ", Author = "Vì sao thế nhỉ", Publicser = "Vì sao thế nhỉ", ReleaseDate = DateTime.Parse("2022-2-12"), Description = "Hay lắm", Price = 1234, CategoryID = 1, Image = "1.jpg" }

                    );
                _context.SaveChanges();
            }
        }
    }
}
