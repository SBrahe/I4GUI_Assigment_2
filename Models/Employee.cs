using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I4GUI_Assigment_2.Models
{
    public enum EmployeeEnum
    {
        Waiter,
        Receptionist,
        Chef
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public EmployeeEnum EmployeeType { get; set; }
    }
}