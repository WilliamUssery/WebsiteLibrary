using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteLibrary
{
    internal class Website
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            static List<Website> websites = new List<Website>(); // IDK why this is red

            static void Main(string[] args) // Not being used yet
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine("\n Website Library");
                    Console.WriteLine("1. Add Website");
                    Console.WriteLine("2. View Websites");
                    Console.WriteLine("3. Update Website");
                    Console.WriteLine("4. Delete Website");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            AddWebsite(); // Need to add all these functions later. That's why they are red
                            break;
                        case "2":
                            ViewWebsites();
                            break;
                        case "3":
                            UpdateWebsite();
                            break;
                        case "4":
                            DeleteWebsite();
                            break;
                        case "5":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }


        }
    }
}
