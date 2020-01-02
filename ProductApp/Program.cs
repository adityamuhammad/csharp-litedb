using System;
using LiteDB;
using ProductApp.Model;
using ProductApp.Repository;
using GraphQL;
using GraphQL.Types;
using System.Collections.Generic;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new ApplicationDbContext();
            var product = new ProductRepository(ctx);
            var item = new ItemRepository(ctx);
            var charger = new Item {  Name = "XiaoMi Charger" };
            var casing = new Item {  Name = "XiaoMi Casing" };
            var handphone = new Product
            {
                Name = "Xiami Note 7",
                Price = 2000000,
                Items = new List<Item> { charger, casing }
            };
            product.Create(handphone);
            item.Create(casing);
            item.Create(charger);
            //item.CreateBatch(new Item[] { charger, casing });
            var products = product.GetAllWithItems();
            foreach (var p in products)
            {
                Console.WriteLine(p.Name);
                foreach (var i in p.Items)
                {
                    Console.WriteLine("Item Name" + i.Name);
                }
            }
        }
    }
}
