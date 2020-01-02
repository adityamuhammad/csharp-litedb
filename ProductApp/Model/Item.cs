using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;

namespace ProductApp.Model
{
    public class Item
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
