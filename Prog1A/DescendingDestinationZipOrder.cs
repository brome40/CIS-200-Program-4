// Program 4
// CIS 200-50
// Fall 2021
// Due: 11/29/2021
// By: 5342897

// File: DescendingDestinationZipOrder.cs
// This class contains the Compare method to order
// the list by destination zip in descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program4
{
    class DescendingDestinationZipOrder : Comparer<Parcel>
    {
        //Compare Method
        //Precondition:  None 
        //Postcondition: Ordering is created based on destination zip descending
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;
            if (p1 == null)
                return -1;
            if (p2 == null)
                return 1;

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip);
        }
    }
}
