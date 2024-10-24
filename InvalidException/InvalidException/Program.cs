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
                Console.WriteLine("1.AddProduct    2.RemoveProduct   3.GetProduct   4.FilterProductsByType    5.FilterProductsByName  6.ShowAll   0.Exit");
                
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
                                price_f = false;
                            }

                        } while (!price_f);

                        Type productType;
                        
                        do
                        {
                            Console.Write("Tip daxil edin (1.Baker, 2.Drink, 3.Meat, 4.Diary): ");
                            string typeInput = Console.ReadLine();

                            
                            if (Enum.TryParse<Type>(typeInput, true, out productType))
                            {
                                break; 
                            }
                            else
                            {
                                Console.WriteLine("Zehmet olmasa dogru daxil edin , 1.Baker, 2.Drink, 3.Meat, 4.Diary.");
                            }
                        } while (true);

                        Product mehsul = new Product(name_product,price,productType);
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
                            Console.WriteLine("1.Baker   2.Drink   3.Meat   4.Diary");
                            
                            bool_get_type=int.TryParse(Console.ReadLine(),out type_get);

                            if(type_get>=0 && type_get <= 4)
                            {
                                bool_get_type=true;

                            }
                            else
                            {
                                bool_get_type = false;
                            }

                        } while (!bool_get_type);

                        magaza.GetProductType(type_get);
                        
                        break;
                    case "5":
                        Console.WriteLine("Mehsul adini daxil edin:");
                        string name= Console.ReadLine();
                        magaza.FilterProductByName(name);
                        break;
                    case "6":
                        magaza.ShowInfo();
                        break;
                    case "0":
                        return;
                        default:
                        break;
                }

            } while (!false);
        }
    }
}
