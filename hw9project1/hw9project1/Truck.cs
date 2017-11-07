// Homework No.9 Exercise No.1
// File Name:     hw9project1.cs
// @author:       Kostyantyn Shumishyn
// Date:          November 6, 2017
//
// Problem Statement: The Truck Child Class of Vehicle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9project1
{
    class Truck : Vehicle
    {
        // Constants
        private const double DEFAULT_LOAD_CAPACITY = 1000;
        private const int DEFAULT_TOW_CAPACITY = 1500;

        // Instance Variables
        protected double loadCapacity;
        protected int towCapacity;

        // Full Constructor
        public Truck (string name, int numCylinders, Person owner, double loadCapacity, int towCapacity)
        {
            base.SetManufacturerName(name);
            base.SetNumCylinders(numCylinders);
            base.SetOwner(owner);
            this.SetLoadCapacity(loadCapacity);
            this.SetTowCapacity(towCapacity);
        }

        // Partial Constructor
        public Truck(double loadCapacity, int towCapacity)
        {
            SetLoadCapacity(loadCapacity);
            SetTowCapacity(towCapacity);
        }

        // Default Constructor - Uses Partial as Template
        public Truck() : this(DEFAULT_LOAD_CAPACITY, DEFAULT_TOW_CAPACITY)
        {
            base.SetManufacturerName(DEFAULT_MANUFACTURER);
            base.SetNumCylinders(DEFAULT_NUM_CYLINDER);
            base.SetOwner(new Person());
        }

        // Mutators
        // Sets the Load Capacity
        public void SetLoadCapacity(double loadCapacity)
        {
            this.loadCapacity = loadCapacity;
        }

        // Sets the Tow Capacity
        public void SetTowCapacity(int towCapacity)
        {
            this.towCapacity = towCapacity;
        }

        // Accessors
        // Gets the Load Capacity
        public double GetLoadCapacity()
        {
            return this.loadCapacity;
        }

        // Gets the Tow Capacity
        public int GetTowCapacity()
        {
            return this.towCapacity;
        }

        // Utility Methods
        // Returns the String representing this Vehicle
        public override string ToString()
        {
            return base.ToString() + String.Format("\nLoad Capacity: {0}\nTow Capacity: {1}", GetLoadCapacity(), GetTowCapacity());
        }

        // Equals Method for a Truck
        public override bool Equals(object obj)
        {
            var truck = obj as Truck;
            return truck != null &&
                   base.Equals(obj) &&
                   loadCapacity == truck.loadCapacity &&
                   towCapacity == truck.towCapacity;
        }
    }
}
