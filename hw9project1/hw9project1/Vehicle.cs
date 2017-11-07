// Homework No.9 Exercise No.1
// File Name:     hw9project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 6, 2017
//
// Problem Statement: The Vehicle Parent Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9project1
{
    enum Manufacturer
    {
        Volkswagen,
        Toyota,
        Nissan,
        Hyundai,
        GM,
        Ford,
        Honda,
        Chrysler,
        PSA,
        Suzuki,
        Mercedez
    };

    class Vehicle
    {
        // Constants
        protected const int DEFAULT_NUM_CYLINDER = 6;
        protected const string DEFAULT_MANUFACTURER = "Mercedez";

        // Instance Variables
        protected Manufacturer name;
        protected int numCylinders;
        protected Person owner;

        // Full Constructor
        public Vehicle(string name, int numCylinder, Person owner)
        {
            SetManufacturerName(name);
            SetNumCylinders(numCylinder);
            SetOwner(owner);
        }

        // Default Constructor - Uses Full as Template
        public Vehicle() : this(DEFAULT_MANUFACTURER, DEFAULT_NUM_CYLINDER, new Person())
        { }

        // Mutators
        // Sets the Manufacturer
        public void SetManufacturerName(string name)
        {
            // Converts String to Enum
            this.name = (Manufacturer)Enum.Parse(typeof(Manufacturer), name);
        }

        // Sets the Number of Cylinders
        public void SetNumCylinders(int numCylinders)
        {
            this.numCylinders = numCylinders;
        }

        // Sets the Owner
        public void SetOwner(Person owner)
        {
            this.owner = owner;
        }

        // Accessors
        // Gets the Manufacturer
        public Manufacturer GetManufacturer()
        {
            return this.name;
        }

        // Gets the Number of Cylinders
        public int GetNumCylinders()
        {
            return this.numCylinders;
        }

        // Gets the Owner
        public Person GetOwner()
        {
            return this.owner;
        }

        // Utility Methods
        // Returns the String representing this Vehicle
        public override string ToString()
        {
            return String.Format("{0}'s Vehicle\nManufacturer: {1}\nNumber of Cylinders: {2}",
                        GetOwner().ToString(), GetManufacturer().ToString(), GetNumCylinders());
        }

        // Equals Method for a Vehicle
        public override bool Equals(object obj)
        {
            var vehicle = obj as Vehicle;
            return vehicle != null &&
                   name == vehicle.name &&
                   numCylinders == vehicle.numCylinders &&
                   EqualityComparer<Person>.Default.Equals(owner, vehicle.owner);
        }
    }
}