using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I4GUI_Assigment_2.Models
{
    public class Room
    {
        public string RoomNumber;

        public int NumberOfChildren;
        public int NumberOfAdults;
        
        public List<BreakfastReservation> BreakfastDates;
    }
}
