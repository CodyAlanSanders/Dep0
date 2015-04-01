using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotDogLover.Models;

namespace HotDogLover.Service
{
    public class HotdogsService
    {
        private static List<Hotdogs> hotdogsList;
        static HotdogsService()
        {
            hotdogsList = new List<Hotdogs>();
            Hotdogs hotdog1 = new Hotdogs()
            {
                Id = 1,
                Name = "Veggie Dog",
                LastAte = "Downtown Dogs",
                LastEaten = new DateTime(),
                Rating = 4
            };
            hotdogsList.Add(hotdog1);

            Hotdogs hotdog2 = new Hotdogs()
            {
                Id = 2,
                Name = "Soy Dog",
                LastAte = "San Andreas Soy Shack",
                LastEaten = new DateTime(),
                Rating = 5
            };
            hotdogsList.Add(hotdog2);

            Hotdogs hotdog3 = new Hotdogs()
            {
                Id = 3,
                Name = "Tempeh Delight",
                LastAte = "Rockford Hills Gastropub",
                LastEaten = new DateTime(),
                Rating = 4
            };
            hotdogsList.Add(hotdog3);
        }

        public List<Hotdogs> listAll()
        {
            return hotdogsList;
        }
        public Hotdogs Get(int id)
        {
            Hotdogs selectedHotdog = new Hotdogs();
            foreach (Hotdogs hotdog in hotdogsList)
            {
                if (hotdog.Id == id)
                {
                    selectedHotdog = hotdog;
                }
            }
            return selectedHotdog;
        }
        public void Add(Hotdogs hotdog)
        {
            hotdogsList.Add(hotdog);
        }
        public void Remove(Hotdogs hotdog)
        {
            hotdogsList.Remove(hotdog);
        }
    }
}