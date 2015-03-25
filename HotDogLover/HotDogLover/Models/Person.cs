using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string ImageUrl { get; set; }
        public string FavoriteDog { get; set; }
        public string LastAte { get; set; }
        public DateTime DateEaten { get; set; }
        public int Rating { get; set; }
    }
}