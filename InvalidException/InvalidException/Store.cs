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
                Console.WriteLine(products[i].ProductType);
                Console.WriteLine();
            }
        }

        
        public void Remove(int id)
        {
            for(int i  = id-1; i < products.Length-1;i++)
            {
                products[i]=products[i+1];
            }
            Array.Resize(ref products,products.Length-1);
            Console.WriteLine("Sorgu icra edildi");
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
                    Console.WriteLine(products[i].ProductType);
                    Console.WriteLine();
                }
            }
        }

        public void GetProductType(int type)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (type==1 && products[i].ProductType.ToString()=="Baker")
                {
                    Console.WriteLine();
                    Console.WriteLine(products[i].Id);
                    Console.WriteLine(products[i].Name);
                    Console.WriteLine(products[i].Price);
                    Console.WriteLine(products[i].ProductType);
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < products.Length; i++)
            {
                if (type == 2 && products[i].ProductType.ToString() == "Drink")
                {
                    Console.WriteLine();
                    Console.WriteLine(products[i].Id);
                    Console.WriteLine(products[i].Name);
                    Console.WriteLine(products[i].Price);
                    Console.WriteLine(products[i].ProductType);
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < products.Length; i++)
            {
                if (type == 3 && products[i].ProductType.ToString() == "Meat")
                {
                    Console.WriteLine();
                    Console.WriteLine(products[i].Id);
                    Console.WriteLine(products[i].Name);
                    Console.WriteLine(products[i].Price);
                    Console.WriteLine(products[i].ProductType);
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < products.Length; i++)
            {
                if (type == 4 && products[i].ProductType.ToString() == "Diary")
                {
                    Console.WriteLine();
                    Console.WriteLine(products[i].Id);
                    Console.WriteLine(products[i].Name);
                    Console.WriteLine(products[i].Price);
                    Console.WriteLine(products[i].ProductType);
                    Console.WriteLine();
                }
            }
        }

        public void FilterProductByName(string name)
        {
            for (int i = 0;i < products.Length;i++)
            {
                if(name == products[i].Name)
                {
                    Console.WriteLine();
                    Console.WriteLine(products[i].Id);
                    Console.WriteLine(products[i].Name);
                    Console.WriteLine(products[i].Price);
                    Console.WriteLine(products[i].ProductType);
                    Console.WriteLine();
                }
            }
        }

        


    }
}
