using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat_rental
{
    internal class Boat
    {
        private int boatNr;
        // Boat weight in KG
        private double weight;
        // Boat lenght in cm
        private double lenght;
        private int enginePower;
        private double hourlyRentalPrice;
        private double damage;

        public int BoatNr
        {
            get
            {
                return this.boatNr;
            }
            set
            {
                if (isPositive(value))
                {
                    this.boatNr = value;
                }
                else
                {
                    throw new Exception("BoatNr must be positive");
                }
            }
        }

        public Boat(double weight, double length, int enginePower, double hourlyRentalPrice)
        {
            this.Weight = weight;
            this.Lenght = length;
            this.EnginePower = enginePower;
            this.HourlyRentalPrice = hourlyRentalPrice;
        }

        public override string ToString()
        {
            return this.boatNr.ToString();
        }
        
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value >= 10)
                {
                    this.weight = value;
                }
                else
                {
                    throw new Exception("Boat weight must be greater than 10");
                }
            }
        }

        public double Lenght
        {
            get
            {
                return this.lenght;
            }
            set
            {
                if (value >= 100)
                {
                    this.lenght = value;
                }
                else
                {
                    throw new Exception("Boat length must be greater than 100 cm");
                }
            }
        }

        public int EnginePower
        {
            get
            {
                return this.enginePower;
            }
            set
            {
                if (isPositive(value))
                {
                    this.enginePower = value;
                }
                else
                {
                    throw new Exception("Engine power must be positive");
                }
            }
        }

        public double HourlyRentalPrice
        {
            get
            {
                return this.hourlyRentalPrice;
            }
            set
            {
                if (isPositive(value))
                {
                    this.hourlyRentalPrice = value;
                }
                else
                {
                    throw new Exception("Hourly rental price must be positive");
                }
            }
        }

        public double Damage {
            get
            {
                return this.damage;
            }
            set
            {
                if (isPositive(value) && value < 100)
                {
                    if(this.damage + value >= 100)
                    {
                        this.damage = 100;
                    }
                    else
                    {
                        this.damage += value;
                    }
                }
                else
                {
                    throw new Exception("Damage must be positive and less than 100");
                }
            }
        }


        private bool isPositive(double nr)
        {
            return nr > 0;
        }
    }
}
