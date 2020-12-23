using System;
namespace MyFirstMVCApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceUSD { get; set; }
    }

    public class Discount
    {
        public int Id { get; set; }
        public decimal Savings { get; set; }
    }

}
