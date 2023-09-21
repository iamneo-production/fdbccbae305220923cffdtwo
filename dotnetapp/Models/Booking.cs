using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int SlotID { get; set; }
        public string UserID { get; set; }
    }
}