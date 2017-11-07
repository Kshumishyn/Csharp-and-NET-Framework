// Homework No.9 Exercise No.1
// File Name:     hw9project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 6, 2017
//
// Problem Statement: Makes a Vehicle Class
//    
// Overall Plan (step-by-step, how you want the code to make it happen):
// 1. Tested most methods of the Person, Vehicle and Truck classes
// 2. No real algorithm, just tested things come out as expected

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9project1
{
    class VehicleDriver
    {
        static void Main(string[] args)
        {
            // Creates People with Constructors
            Person alexis = new Person();
            Person kostyantyn = new Person("Kostyantyn");

            // Tests Person Equals and ToString - Should be False
            Console.WriteLine("Is " + alexis + " the same person as " + kostyantyn + "? " + kostyantyn.Equals(alexis));

            // Creates Vehicles with Constructors
            Vehicle alexisVehicle = new Vehicle("Volkswagen", 6, alexis);
            Vehicle kostyantynVehicle = new Vehicle();

            // Uses Vehicle Set method
            kostyantynVehicle.SetOwner(kostyantyn);

            // Uses the Vehicle Get methods - Should be Kostyantyn's 6 Cylinder Mercedez
            Console.WriteLine("\n" + kostyantynVehicle.GetOwner() + "'s car is a " + kostyantynVehicle.GetNumCylinders() + " cylinder " + kostyantynVehicle.GetManufacturer() + ".");

            // Creates a Truck
            Truck awesomeTruck = new Truck("GM", 12, new Person("Kevin"), 125.0, 1000);

            // Tests Truck's toString
            Console.WriteLine("\n" + awesomeTruck.ToString());

            // Checks cross Inheritance Equals Methods - Should be True by technicality
            Vehicle otherAwesomeTruck = new Vehicle("GM", 12, new Person("Kevin"));
            Console.WriteLine("\nIs this Vehicle a clone of Kevin's Truck?! " + otherAwesomeTruck.Equals(awesomeTruck));
            
            // Waits to Close Console
            Console.ReadLine();
            
        }
    }
}
