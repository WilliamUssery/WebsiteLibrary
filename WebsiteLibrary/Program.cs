using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteLibrary;


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
        static List<Website> websites = new List<Website>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nWebsite Library");
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
                        AddWebsite();
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

        static void ViewWebsites()
        {
            if (websites.Count == 0)
            {
                Console.WriteLine("No websites to display.");
                return;
            }

            foreach (var site in websites)
            {
                Console.WriteLine($"Name: {site.Name}, Link: {site.Link}, Description: {site.Description}, Rating: {site.Rating}");
            }
        }

        static void UpdateWebsite()
        {
            Console.Write("Enter the name of the website you want to update: ");
            string name = Console.ReadLine();

            var site = websites.FirstOrDefault(w => w.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (site == null)
            {
                Console.WriteLine("Website not found.");
                return;
            }

            Console.Write("Enter new description (leave blank to keep current): ");
            string description = Console.ReadLine();
            if (!string.IsNullOrEmpty(description)) site.Description = description;

            Console.Write("Enter new rating (1-10, leave blank to keep current): ");
            string ratingInput = Console.ReadLine();
            if (int.TryParse(ratingInput, out int newRating) && newRating >= 1 && newRating <= 10)
            {
                site.Rating = newRating;
            }

            Console.WriteLine("Website updated.");
        }

        static void DeleteWebsite()
        {
            Console.Write("Enter the name of the website you want to delete: ");
            string name = Console.ReadLine();

            var site = websites.FirstOrDefault(w => w.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (site == null)
            {
                Console.WriteLine("Website not found.");
                return;
            }

            websites.Remove(site);
            Console.WriteLine("Website deleted.");
        }
    }
}
