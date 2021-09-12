using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Item
    {
        public string name;
        double price;
        double weight;
        public static double getPrice()
        {
            Item Price = new Item();
            double  ;
            return ;
        }
        public static double returnWeight()
        {
            return Console.WriteLine(name);
        }
    }

    class Bill
    {
        Item pItem = new Item();
        public string[] itemList = new string[10];
        
        public static void getFinalbill()
        {
            Console.WriteLine("Your final bill is: ");
        }
        public static void getTotalWeight()
        {
            Console.WriteLine("Your total weight is: ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bill pBill = new Bill();
            Item pItem = new Item();

            Console.WriteLine("Please key in each item one by one, type in \"end\" to end input.");
            for (int i = 0; i <= 10; i++)
            {
                pItem.name = Console.ReadLine();
                if (pItem.name == "end")
                {
                    break;
                }
                else
                {
                    pBill.itemList[i] = pItem.name;
                }
            }

            foreach (string item in pBill.itemList)
            {
                if (item != null) 
                {
                    Console.Write(item + ", ");
                }
                else
                {
                    break;
                }
            }

            Bill.getFinalbill();
            Bill.getTotalWeight();
            

            Console.ReadLine();
        }
    }
}
