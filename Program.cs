using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizedProductApp.Models;

namespace OptimizedProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductInfo product1 = new ProductInfo(1,"PS5",49500.50,0.35);
            ProductInfo product2 = new ProductInfo(2,"X-Box",51300.45,0.20);  
            
            PrintDetails(product1);
            Console.WriteLine("====================================>");
            PrintDetails(product2);

        }

        static void PrintDetails(ProductInfo product) {

            Console.WriteLine($" ID : {product.Id}\n Name:{product.Name}\n" +
                $" Discount : {product.DiscountPercentage}\n" +
                $" Price before discount :{product.Price}\n" +
                $" Price after discount: {product.DiscountCalculation()}");
        }
    }
}















/*0.5 will be set to value and then value will be 
                                                    will be validated through if else if conditions 
                                                     and then the proper value will be set to 
                                                         _discountPercentage*/ 