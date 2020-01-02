using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Model
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        [BsonRef("items")]
        public List<Item> Items { get; set; }

    }
}
