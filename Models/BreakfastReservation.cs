using System;
using System.Collections.Generic;
namespace I4GUI_Assigment_2.Models
{
    enum ChildOrAdult
    {
        
    }
    public class BreakfastReservation
    {
        public DateTime Date { get; set; }
        public int NumberOfChildReservations{ get; set; }
        public int NumberOfAdultReservations{ get; set; }
        public int NumberOfChildrenCheckedIn{ get; set; }
        public int NumberOfAdultsCheckedIn{ get; set; }
    }
}