using _12._09._23.CW.Warehouse;
using _12._09._23.CW.Warehouse.Models;

namespace _12._09._23.CW
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            DatabaseAccess access = new DatabaseAccess();
            Menu(access);
        }

        private static void Menu(DatabaseAccess access)
        {
            int choice = -1;
            while(choice != 0)
            {
                Console.WriteLine("\nВведiть свiй вибiр\n");
                Console.WriteLine("1 - Вiдображення всiєї iнформацiї про товар");
                Console.WriteLine("2 - Вiдображення всiх типiв товарiв");
                Console.WriteLine("3 - Вiдображення всiх постачальникiв");
                Console.WriteLine("4 - Показати товар з максимальною кiлькiстю");
                Console.WriteLine("5 - Показати товар з мiнiмальною кiлькiстю");
                Console.WriteLine("6 - Показати товар з максимальною собiвартiстю");
                Console.WriteLine("7 - Показати товар з мiнiмальною собiвартiстю");
                Console.WriteLine();
                Console.WriteLine("0 - Вихiд");

                if(int.TryParse(Console.ReadLine(), out choice) == false)
                {
                    choice = -1;
                }

                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        access.PrintAllProducts();
                        break;
                    case 2:
                        Console.Clear();
                        access.PrintAllTypes();
                        break;
                    case 3:
                        Console.Clear();
                        access.PrintAllManufacturers();
                        break;
                    case 4:
                        Console.Clear();
                        access.PrintProductsMaxNumber();
                        break;
                    case 5:
                        Console.Clear();
                        access.PrintProductsMinNumber();
                        break;
                    case 6:
                        Console.Clear();
                        access.PrintProductsMaxCostPrice();
                        break;
                    case 7:
                        Console.Clear();
                        access.PrintProductsMinCostPrice();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Помилковий вибiр!");
                        break;
                }
            }
        }
    }
}