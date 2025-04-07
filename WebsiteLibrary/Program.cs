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
        static List<Website> websites = new List<Website>(); // Moved the list and main argument method to this line 
        static void Main(string[] args)
        {
            
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
                            AddWebsite(); // Added this Function
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

    static void AddWebsite()
        {
            Console.Write("Enter website name: ");
            string name = Console.ReadLine();

            Console.Write("Enter website link: ");
            string link = Console.ReadLine();

            Console.Write("Enter website description: ");
            string description = Console.ReadLine();

            int rating;
            while (true)
            {
                Console.Write("Enter website rating (1–10): ");
                if (int.TryParse(Console.ReadLine(), out rating) && rating >= 1 && rating <= 10)
                {
                    break;
                }
                Console.WriteLine("Please enter a number from 1 to 10.");
            }

            Website newSite = new Website
            {
                Name = name,
                Link = link,
                Description = description,
                Rating = rating
            };

            websites.Add(newSite);
            Console.WriteLine("Website added");
        }

    }
