using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidException
{
    public class Store
    {
        public Product[] products;

        public Store()
        {
            products = new Product[0];
        }

        public void Add(Product product)
        {
            Array.Resize(ref products,products.Length+1);
            products[products.Length-1] = product;
        }

        public void ShowInfo()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(products[i].Id);
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].Price);
                Console.WriteLine();
            }
        }

        
        public void Remove(int id)
        {
            for(int i  = id; i < products.Length-1;i++)
            {
                products[i]=products[i+1];
            }
            Array.Resize(ref products,products.Length-1);
        }

        public void GetProduct(int id)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if(products[i].Id == id)
                {
                    Console.WriteLine();                    
                    Console.WriteLine(products[i].Name);
                    Console.WriteLine(products[i].Price);
                    Console.WriteLine(Type.);
                    Console.WriteLine();
                }
            }
        }

        public void GetProductType(int type)
        {
            switch (type)
            {
                case 0:
                    Console.WriteLine(Type.Baker);
                    break;
                case 1:
                    Console.WriteLine(Type.Drink);
                    break;
                default:
                    break;
            }
        }


    }
}
