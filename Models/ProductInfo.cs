using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedProductApp.Models
{
    internal class ProductInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int Id { get; set; }

        private double _discountPercentage;

        private double _maxDiscountPercentage = 0.4;

        private double _minDiscountPercentage = 0.2;
        public double DiscountPercentage
        {
            set
            {
                if (value > _maxDiscountPercentage)
                    _discountPercentage = _maxDiscountPercentage;
                else if (value < _minDiscountPercentage)
                    _discountPercentage = _minDiscountPercentage;
                else
                    _discountPercentage = value;
            }

            get
            {
                return _discountPercentage;

            }

        }

        public ProductInfo() {

            Console.WriteLine("Welcome to C#");
        }

        public ProductInfo(int id , string name , double price , double discountPercentage):this() //this() will call the default constructor which is defined above
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double DiscountCalculation()
        {
            return (Price - (Price * DiscountPercentage));
        }

    }
}
    

