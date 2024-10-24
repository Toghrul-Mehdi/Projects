using Core;

namespace InvalidException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            

            Store magaza = new Store();
            do
            {
                Console.WriteLine("1.AddProduct    2.RemoveProduct   3.GetProduct   4.FilterProductsByType    5.FilterProductsByName");
                
                string secim = Console.ReadLine();

                 
                
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Mehsul adi daxil edin:");
                        string name_product=Console.ReadLine();
                        
                        
                        double price;
                        bool price_f = false;
                        do
                        {
                          Console.WriteLine("Price daxil edin:");
                          price_f=double.TryParse(Console.ReadLine(), out price);
                            if (price > 0)
                            {
                                price_f=true;
                            }
                            else
                            {
                                throw new PriceMustBeGratherThanZeroException("0dan kicik ola bilmez");
                            }

                        } while (!price_f);
                        int type;
                        bool bool_type=false;
                        do
                        {
                            Console.WriteLine("Type daxil et:");
                            bool_type = int.TryParse(Console.ReadLine(), out type);
                            
                        } while (!bool_type);



                        Product mehsul = new Product(name_product,price,type);
                        magaza.Add(mehsul);                     
                                                

                        break;
                        int id;
                        
                    case "2":
                        Console.WriteLine("Mehsul id daxil edin:");

                        bool id_f= int.TryParse(Console.ReadLine(), out id);
                        magaza.Remove(id);
                        
                        break;
                        int id_get;
                    case "3":
                        Console.WriteLine("Id daxil edin:");
                        bool id_get_f = int.TryParse(Console.ReadLine(), out id_get);
                        magaza.GetProduct(id_get);
                        break;
                    case "4":
                        bool bool_get_type = false;
                        int type_get;
                        do
                        {
                            Console.WriteLine("Type daxil et:");
                            bool_get_type=int.TryParse(Console.ReadLine(),out type_get);

                        } while (!bool_get_type);
                        magaza.GetProductType(type_get);
                        
                        
                        break;
                }

            } while (!false);
        }
    }
}
