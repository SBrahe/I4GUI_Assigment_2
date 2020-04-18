using System;
using System.Collections.Generic;
namespace I4GUI_Assigment_2.Models
{
    enum ChildOrAdult
    {
        
    }
    public class BreakfastReservation
    {
        public DateTime Date;
        public int NumberOfChildReservations;
        public int NumberOfAdultReservations;
        public int NumberOfChildrenCheckedIn;
        public int NumberOfAdultsCheckedIn;
    }
}