﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {
        }

        public override void Driven(double distance)
        {
            double sumerComsumation = Consumption + 0.9;
            if (sumerComsumation * distance <= FuelQuantity)
            {
                FuelQuantity -= distance * sumerComsumation;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double fuelInTo)
        {
            if (TankCapacity >= fuelInTo + FuelQuantity && fuelInTo > 0)
            {
                FuelQuantity += fuelInTo;
            }
            else
            {
                if (fuelInTo <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");

                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuelInTo} fuel in the tank");
                }
            }
        }
    }
}
