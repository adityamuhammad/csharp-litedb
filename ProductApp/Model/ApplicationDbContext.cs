using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Model
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("filename=database.db; password=1234")
        {
            var mapper = BsonMapper.Global;
            mapper.Entity<Product>().DbRef(x => x.Items, "items");
        }
    }
}
