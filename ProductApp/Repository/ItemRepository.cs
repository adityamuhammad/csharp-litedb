using System;
using System.Collections.Generic;
using System.Text;
using ProductApp.Model;

namespace ProductApp.Repository
{
    class ItemRepository
    {
        private readonly ApplicationDbContext _context;
        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAll()
        {
            var items = _context.GetInstance().GetCollection<Item>("items");
            return items.FindAll();
        }

        public void Create(Item item)
        {
            var items = _context.GetInstance().GetCollection<Item>("items");
            items.Insert(item);
        }

        public void CreateBatch(Item[] item)
        {
            var items = _context.GetInstance().GetCollection<Item>("items");
            items.Insert(item);
        }
    }
}
