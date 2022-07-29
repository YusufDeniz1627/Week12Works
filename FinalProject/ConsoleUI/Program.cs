using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //S-o-lid
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new IFCategoryDal());
            //foreach (var category in categoryManager.GetById(2))
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new IFProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
