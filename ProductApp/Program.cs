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
            var products = product.GetAllWithItems();
            foreach (var p in products)
            {
                Console.WriteLine(p.Name);
                foreach (var i in p.Items)
                {
                    Console.WriteLine(i.Name);
                }
            }
        }
    }
}
