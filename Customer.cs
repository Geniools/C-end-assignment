using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat_rental
{
    internal class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public Customer(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else throw new Exception("Id must be greater than 0");
            }
        }

        public override string ToString()
        {
            return this.id.ToString() + ": " + this.firstName + " " + this.lastName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!isNull(value) && value.Length > 2)
                {
                    this.firstName = value.Trim();
                }
                else
                {
                    throw new Exception("First name must be longer than 2 characters");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (!isNull(value) && value.Length > 2)
                {
                    this.lastName = value.Trim();
                }
                else
                {
                    throw new Exception("Last name must be longer than 2 characters");
                }
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                if(getAge(value) > 18 && getAge(value) < 99)
                {
                    this.birthDate = value.Date;
                }
                else
                {
                    throw new Exception("Customer must be between 18 and 99 years old");
                }
            }
        }


        private int getAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }

        private bool isNull(string str)
        {
            return str == null || str.Trim().Length == 0;
        }
    }
}
