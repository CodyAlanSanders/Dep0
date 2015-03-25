using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.Models
{
    public class Hotdog
    {
        public int HotdogId { get; set; }
        public string Name { get; set; }
        public DateTime LastEaten { get; set; }
        public int Rating { get; set; }
    }
}