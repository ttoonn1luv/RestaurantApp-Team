using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", " Snacks ", 4.2),
                new Restaurant(4, "Haidilao Hot Pot", " Hot Pot ", 4.8)
            };

            Console.WriteLine($"เพิ่มร้านอาหาร : ");
            Console.Write($"ป้อนชื่อร้านอาหาร :");
            string name = Console.ReadLine();
            Console.WriteLine($"ป้อนประเภท : ");
            string type = Console.ReadLine();
            Console.Write($"ป้อนคะแนน :");
            string rate = Console.ReadLine();

            
            double ratingStore = double.Parse(rate);

            int newId = restaurants.Count + 1;

         
            restaurants.Add(new Restaurant(newId, name, type, ratingStore));


            var highRatedRestaurants = restaurants.Where(r => r.Rate >= 4.5).ToList();

            double highetScore = restaurants.Max(r => r.Rate);
            double lowestScrore = restaurants.Min(r => r.Rate);

            Console.WriteLine($"คะแนนสูงสุด {highetScore}");
            Console.WriteLine($"คะแนนต่ำสุด {lowestScrore}");

            foreach (var item in highRatedRestaurants)
            {
                Console.WriteLine($"{item.Name}  {item.Type.Trim()}  {item.Rate}");
            }

            
            int totalRestaurants = highRatedRestaurants.Count;
            double averageRate = highRatedRestaurants.Average(r => r.Rate);

            

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"จำนวนร้านทั้งหมด: {totalRestaurants} restaurant ");
            Console.WriteLine($"ค่าเฉลี่ยคะแนนรีวิวทั้งหมด: {averageRate:F2}"); 
            Console.WriteLine(new string('-', 40));
            






            Console.WriteLine("Chanthima Chamnivesapong");
            Console.WriteLine("Treenet Saraithong");
            Console.WriteLine("Anukun Buatsanthia");
            Console.WriteLine("ttoonn");
        }
    }
           
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }

        public Restaurant(int id, string name, string type, double rate)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
        }
    }
}
