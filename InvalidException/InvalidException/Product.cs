﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidException
{
    public class Product 
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price;

        public Type ProductType { get; set; }
        
        

        public double _Price
        {
            get { return Price; }

            set
            {
                if (value > 0)
                {
                    Price = value;
                }
                else
                {
                    throw new PriceMustBeGratherThanZeroException("0dan kicik ola bilmez");
                }
            }
        }
        public Product()
        {            
            
        }
        public Product(string name , double price,Type productType)
        {
            Id = ++_id;
            ProductType = productType;
            Name = name;
            Price = price;
        }
        


        

    }
}
