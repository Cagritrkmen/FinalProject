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
            //ProductTest();
            //CategoryGetByIdTest();

            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()) );
            var result = productManager.GetAll();
            if (result.Success == true)
            {
                foreach (var product in productManager.GetAll().Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CategoryGetByIdTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            
            Console.WriteLine(categoryManager.GetById(2).Data.CategoryName);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if(result.Success== true)
            {
                   foreach (var product in productManager.GetProductDetails().Data)
                   {
                       Console.WriteLine(product.ProductName+"/"+ product.CategoryName);
                   }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
