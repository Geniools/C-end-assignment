using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat_rental
{
    internal class TimeSlot
    {
        private int id;
        private Boat boat;
        private Customer customer;
        private int boatNr;
        private int customerId;
        private DateTime day;
        private DateTime startTime;
        private DateTime endTime;
        private double fuelConsumption;

        public TimeSlot(DateTime day, DateTime startTime, DateTime endTime, int boatNr, int customerId)
        {
            this.Day = day;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.BoatNr = boatNr;
            this.CustomerId = customerId;

            initializeBoat();
            initializeCustomer();
        }

        public int Id
        {
            // get
            // {
            //     return this.id;
            // }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("Id must be greater than 0");
                }
            }
        }

        public Boat Boat
        {
            get
            {
                return this.boat;
            }
            set
            {
                this.boat = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
        }

        private void initializeBoat()
        {
            int boatNr = this.BoatNr;
            DataManagement dm = new DataManagement();
            DataTable boatDetails = dm.runCustomerQuery("SELECT * FROM Boat WHERE boatNr = " + boatNr);

            this.boat = new Boat(
                float.Parse(boatDetails.Rows[0]["weight"].ToString()),
                float.Parse(boatDetails.Rows[0]["lenght"].ToString()),
                int.Parse(boatDetails.Rows[0]["enginePower"].ToString()),
                float.Parse(boatDetails.Rows[0]["hourlyRentalPrice"].ToString())
            )
            {
                BoatNr = int.Parse(boatDetails.Rows[0]["boatNr"].ToString())
                //Damage = float.Parse(boatDetails.Rows[0]["damage"].ToString())
            };
        }

        private void initializeCustomer()
        {
            int customerId = this.CustomerId;
            DataManagement dm = new DataManagement();
            DataTable customerDetails = dm.runCustomerQuery("SELECT * FROM Customer WHERE Id = " + customerId);

            this.customer = new Customer(
                customerDetails.Rows[0]["firstName"].ToString(),
                customerDetails.Rows[0]["lastName"].ToString(),
                DateTime.Parse(customerDetails.Rows[0]["birthDate"].ToString())
            );
        }
        
        public int BoatNr
        {
            get
            {
                return this.boatNr;
            }
            set
            {
                if (value > 0)
                {
                    this.boatNr = value;
                    //initializeBoat();
                }
                else
                {
                    throw new ArgumentException("Boat Nr must be greater than 0");
                }
            }
        }

        public int CustomerId
        {
            get
            {
                return this.customerId;  
            }
            set
            {
                if (value > 0)
                {
                    this.customerId = value;
                }
                else
                {
                    throw new ArgumentException("Customer Id must be greater than 0");
                }
            }
        }

        public DateTime Day
        {
            get
            {
                return this.day;
            }
            set
            {
                if (value != null)
                {
                    this.day = value;
                }
                else
                {
                    throw new ArgumentException("Day must be a valid date");
                }
            }
        }

        public DateTime StartTime
        {
            get
            {
                return this.startTime;
            }
            set
            {
                if (int.Parse(value.ToString("HH")) < 7 || int.Parse(value.ToString("HH")) > 22)
                {
                    throw new ArgumentException("Start time must be between 7 and 22");
                }
                else
                {
                    this.startTime = value;
                }
            }
        }

        public DateTime EndTime
        {
            get
            {
                return this.endTime;
            }
            set
            {
                if (int.Parse(value.ToString("HH")) < 7 || int.Parse(value.ToString("HH")) > 22 || int.Parse(value.ToString("HH")) < int.Parse(this.startTime.ToString("HH")))
                {
                    throw new ArgumentException("End time must be between 7 and 22");
                }
                else
                {
                    this.endTime = value;
                }
            }
        }

        
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                if (value > 1)
                {
                    this.fuelConsumption = value;
                }
                else
                {
                    throw new Exception("Fuel consumption must be greater than 1");
                }
            }
        }

        public double getDuration()
        {
            return this.endTime.Subtract(this.startTime).TotalHours;
        }

        public double getAllowedFuelConsumption(int literPerMinute)
        {
            return 1;
        }

        public double getExtraFuelSurchage()
        {
            return 1;
        }
    }
}
