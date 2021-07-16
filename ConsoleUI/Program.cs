using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryGetByIdTest();


        }

        private static void CategoryGetByIdTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            Console.WriteLine(categoryManager.GetById(2).CategoryName);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"/"+ product.CategoryName);
            }
        }
    }
}
