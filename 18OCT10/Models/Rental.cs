using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _18OCT10.Models
{
    public class Rental
    {
        public int ID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Car Car { get; set; }
        public User Customer { get; set; }
    }
}