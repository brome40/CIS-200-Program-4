// Program 4
// CIS 200-50
// Fall 2021
// Due: 11/29/2021
// By: 5342897

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them. It then sorts these parcels
// by cost in ascending order, and then by destination zip code in descending order. 
// It will also display the list of parcels sorted by parcel type and subsorted by cost.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Program4
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Jacob Green", "443 Verde Ave.",
                "Portland", "OR", 97035); // Test Address 5
            Address a6 = new Address("Peter Parker", "20 Ingram St.",
                "Flushing", "NY", 11375); // Test Address 6
            Address a7 = new Address("Tony Stark", "10880 Malibu Point",
                "Malibu", "CA", 90265); // Test Address 7
            Address a8 = new Address("Eric Adams", "602 5th St.", "Room 13",
                "Topeka", "KS", 66546); // Test Address 8

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            GroundPackage gp1 = new GroundPackage(a1, a5, 5, 13, 3, 15); //Test GroundPackage 1
            GroundPackage gp2 = new GroundPackage(a2, a7, 6, 7, 4, 10);  //Test GroundPackage 2
            GroundPackage gp3 = new GroundPackage(a3, a4, 7, 4, 5, 20);  //Test GroundPackage 3

            NextDayAirPackage ndap1 = new NextDayAirPackage(a2, a8, 15, 10, 15, 77, 3.50M); //Test NextDayAirPackage 1
            NextDayAirPackage ndap2 = new NextDayAirPackage(a7, a3, 6, 10, 4, 8, 4.14M); //Test NextDayAirPackage 2
            NextDayAirPackage ndap3 = new NextDayAirPackage(a5, a1, 9, 3, 5, 12, 5.00M); //Test NextDayAirPackage 3

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a3, a2, 5, 5, 4, 11, TwoDayAirPackage.Delivery.Saver); //Test TwoDayAirPackage 1 
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a7, 6, 3, 5, 100, TwoDayAirPackage.Delivery.Early); //Test TwoDayAirPackage 2 
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a1, 3, 3, 3, 5, TwoDayAirPackage.Delivery.Saver);  //Test TwoDayAirPackage 3

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(l1); // Populate list
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort(); //Sort by default (ascending cost)

            WriteLine("Sorted by Ascending Cost:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort(new DescendingDestinationZipOrder()); //Sort by destination zip in descending order

            WriteLine("Sorted by Descending Destination Zip:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            parcels.Sort(new AscendingParcelTypeOrder()); //Sort by type ascending then by cost descending

            WriteLine("Sorted by Parcel Type ascending, then by Cost descending:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
