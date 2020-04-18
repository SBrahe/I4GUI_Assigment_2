using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I4GUI_Assigment_2.Models
{
    public class Room
    {
        public string RoomNumber { get; set; }

        public int NumberOfChildren { get; set; }
        public int NumberOfAdults { get; set; }
        
        public List<BreakfastReservation> BreakfastDates { get; set; }
    }
}
