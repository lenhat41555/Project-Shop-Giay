using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBanGiay.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Despition { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Amount { set; get; }
        public string Color { set; get; }
        public string Brand { set; get; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
