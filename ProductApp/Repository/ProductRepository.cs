using System;
using System.Collections.Generic;
using System.Text;
using ProductApp.Model;

namespace ProductApp.Repository
{
    class ProductRepository
    {

        private readonly ApplicationDbContext _context;
        public ProductRepository() { }
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            var products = _context.GetInstance().GetCollection<Product>("products");
            return products.FindAll();
        }
        public IEnumerable<Product> GetAllWithItems()
        {
            var products = _context.GetInstance().GetCollection<Product>("products");
            return products.Include(x => x.Items).FindAll();
        }
    }
}
