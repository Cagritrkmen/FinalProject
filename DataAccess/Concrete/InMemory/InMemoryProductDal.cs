using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductID = 1, CategoryID= 1, ProductName= "Bardak", UnitPrice=15,UnitsInStock=15},
                new Product{ProductID = 2, CategoryID= 1, ProductName= "Kamera", UnitPrice=500,UnitsInStock=3},
                new Product{ProductID = 3, CategoryID= 2, ProductName= "Telefon", UnitPrice=1500,UnitsInStock=2},
                new Product{ProductID = 4, CategoryID= 2, ProductName= "Klavye", UnitPrice=150,UnitsInStock=65},
                new Product{ProductID = 5, CategoryID= 2, ProductName= "Fare", UnitPrice=85,UnitsInStock=1}
            };
       }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete= null;
            //foreach (Product p in _products)
            //{
            //    if(product.ProductID== p.ProductID)
            //    {
            //        productToDelete = p;// burda yaptığımız eğer listedeki ürünün ürün numarasıyla p'nin ürün listesinde sırayla gezdiği ürünlerden biriyle ürün numarası eşitse bu ikisinin referansını eşitle demek  
            //    }
            //}
            //_products.Remove(productToDelete);// ve sonrasına referanslarını eşitlediğimiz için de sil dediğimzde artık silecektir. 
            //*********************Ama Kolay Yol Var*******************************
            // c# ta LINQ diye bi şey var vebunun anlamı Language Integrated Query 
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);// burdaki sorgu işte yukardaki foreachın yaptığını tek satırlık kodla yapıyor => lambda işareti bu da; bu p şu demek 
            _products.Remove(productToDelete);// üstteki SingleOrDefoult Metotunu kullnabilmek için ütteki linq kütüphanesini yazmalıtyız


        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {// günderdiğim ürünIdsine sahip olan listedeki ürünü bul demek, ki biz onu güncelleyebilelim  
            Product productToUptade = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUptade.ProductName = product.ProductName;
            productToUptade.CategoryID = product.CategoryID;
            productToUptade.UnitPrice = product.ProductID;
            productToUptade.UnitsInStock = product.UnitsInStock; 
        }
    }
}
