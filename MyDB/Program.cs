using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace MyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {
                using (IDbContextTransaction t = db.Database.BeginTransaction())
                {
                    Console.WriteLine("Product를 포합한 모든 카테고리: ");
                    IQueryable<Category> cats = db.Categories.Include(c => c.Products);
                    foreach (Category c in cats)
                    {
                        Console.WriteLine($"{c.CategoryName} 에는 총 {c.Products.Count} 개의 제품이 있습니다.");
                    }
                }
            }
        }
    }
}
