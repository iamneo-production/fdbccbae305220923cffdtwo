using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Models
{
    public class Slot
    {
        public int SlotID { get; set; }
        public string Time { get; set; }    
        public double Duration { get; set; }
        public int Capacity { get; set; }
    }
}