// Program 4
// CIS 200-50
// Fall 2021
// Due: 11/29/2021
// By: 5342897

// File: AscendingParcelTypeOrder.cs
// This class contains the Compare method to order
// the list by parcel type in ascending order, and
// suborder by cost in descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program4
{
    class AscendingParcelTypeOrder : Comparer<Parcel>
    {
        //Compare Method
        //Precondition:  None 
        //Postcondition: Ordering is created based on ascending parcel type, then by cost descending
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;
            if (p1 == null)
                return -1;
            if (p2 == null)
                return 1;

            if (p1.GetType().ToString() != p2.GetType().ToString()) //is there a difference in type?
                return p1.GetType().ToString().CompareTo(p2.GetType().ToString()); //order by type ascending
            else
                return (-1) * p1.CalcCost().CompareTo(p2.CalcCost()); //if the type is the same, order by cost descending
        }
    }
}
