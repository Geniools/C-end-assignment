using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace boat_rental
{
    interface IDataManagement
    {
        double getTotalTurnover(DateTime day);
        double getTotalRentalTime(DateTime day);
        double getBoatDamage(DateTime day);
        Boat getRentedShortestTimeBoat(DateTime day);
        double[] getBoatNrHighestFuelConsumption(DateTime day);
    }
    
    internal class DataManagement : IDataManagement
    {
        // Connection string to the database
        private string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=boat_rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public DataTable runCustomerQuery(string query)
        {
            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, CONNECTION_STRING);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return null;
        }

        public void deleteObjectDatabase(string objectType, int Id)
        {
            string primaryKey = "Id";
            switch (objectType.ToLower())
            {
                case "boat":
                    primaryKey = "boatNr";
                    objectType = "dbo.Boat";
                    break;
                case "customer":
                    objectType = "dbo.Customer";
                    break;
                case "timeslot":
                    objectType = "dbo.TimeSlot";
                    break;
                default:
                    throw new Exception("Unknown object type");
            }
            
            string query = "DELETE FROM " + objectType + " WHERE "+ primaryKey +" = @id";
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Id;

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        
        public void updateObjectDatabase(object objectToUpdate)
        {
            string tableName = "";
            string primaryKey = "";
            var tableColumns = new List<KeyValuePair<string, SqlDbType>>();

            switch (objectToUpdate.GetType().Name.ToLower())
            {
                case "boat":
                    tableName = "Boat";
                    primaryKey = "boatNr";
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("weight", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("lenght", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("enginePower", SqlDbType.Int));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("hourlyRentalPrice", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("damage", SqlDbType.Float));
                    break;
                case "timeslot":
                    tableName = "TimeSlot";
                    primaryKey = "Id";
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("day", SqlDbType.Date));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("startTime", SqlDbType.DateTime));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("endTime", SqlDbType.DateTime));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("fuelConsumption", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("boatNr", SqlDbType.Int));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("customerId", SqlDbType.Int));
                    break;
                case "customer":
                    tableName = "Customer";
                    primaryKey = "Id";
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("firstName", SqlDbType.VarChar));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("lastName", SqlDbType.VarChar));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("birthDate", SqlDbType.DateTime));
                    break;
                default:
                    throw new Exception("Unknown object type");
            }
            try
            {
                // Creating the query
                string query = "UPDATE " + tableName + " SET ";
                foreach (KeyValuePair<string, SqlDbType> column in tableColumns)
                {
                    query += column.Key + " = @" + column.Key + ",";
                }
                // Removing the last "," from the query
                
                query = query.Remove(query.Length - 1);
                query += " WHERE " + primaryKey + " = @primaryKey";

                // Creating an sql connection
                SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);

                // Creating an sql command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Preparing statement - avoid sql injection
                foreach (KeyValuePair<string, SqlDbType> column in tableColumns)
                {
                    string col = "@" + column.Key;
                    // Changing the first letter of the property name to uppercase (otherwise it would return null)
                    string prop = column.Key[0].ToString().ToUpper() + column.Key.Substring(1);
                    sqlCommand.Parameters.Add(col, column.Value).Value = objectToUpdate.GetType().GetProperty(prop).GetValue(objectToUpdate);
                }
                
                string primaryUpper = primaryKey[0].ToString().ToUpper() + primaryKey.Substring(1);
                sqlCommand.Parameters.Add("primaryKey", SqlDbType.Int).Value = objectToUpdate.GetType().GetProperty(primaryUpper).GetValue(objectToUpdate);
                // Opening the connection to the database
                sqlConnection.Open();
                // Executing the query created (together with the prepared statement)
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public void insertObjectDatabase(Object objectToInsert)
        {
            string tableName = "";
            var tableColumns = new List<KeyValuePair<string, SqlDbType>>();
            
            switch (objectToInsert.GetType().Name.ToLower())
            {
                case "boat":
                    tableName = "Boat";
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("weight", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("lenght", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("enginePower", SqlDbType.Int));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("hourlyRentalPrice", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("damage", SqlDbType.Float));
                    break;
                case "timeslot":
                    tableName = "TimeSlot";
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("day", SqlDbType.Date));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("startTime", SqlDbType.DateTime));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("endTime", SqlDbType.DateTime));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("fuelConsumption", SqlDbType.Float));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("boatNr", SqlDbType.Int));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("customerId", SqlDbType.Int));
                    break;
                case "customer":
                    tableName = "Customer";
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("firstName", SqlDbType.VarChar));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("lastName", SqlDbType.VarChar));
                    tableColumns.Add(new KeyValuePair<string, SqlDbType>("birthDate", SqlDbType.DateTime));
                    break;
                default:
                    throw new Exception("Unknown object type");
            }
            
            try
            {
                // Creating the query
                string query = "INSERT INTO " + tableName + "(";
                foreach (KeyValuePair<string, SqlDbType> column in tableColumns)
                {
                    query += column.Key + ",";
                }
                // Removing the last "," from the query
                query = query.Remove(query.Length - 1);
                query += ") VALUES(";
                foreach (KeyValuePair<string, SqlDbType> column in tableColumns)
                {
                    query += "@" + column.Key + ",";
                }
                // Removing the last "," from the query
                query = query.Remove(query.Length - 1);
                query += ")";
                
                // Creating an sql connection
                SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
                
                // Creating an sql command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Preparing statement - avoid sql injection
                foreach (KeyValuePair<string, SqlDbType> column in tableColumns)
                {
                    string col = "@" + column.Key;
                    // Changing the first letter of the property name to uppercase (otherwise it would return null)
                    string prop = column.Key[0].ToString().ToUpper() + column.Key.Substring(1);
                    sqlCommand.Parameters.Add(col, column.Value).Value = objectToInsert.GetType().GetProperty(prop).GetValue(objectToInsert);
                }
                // Opening the connection to the database
                sqlConnection.Open();
                // Executing the query created (together with the prepared statement)
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public DataTable getDatabaseObjects(string obj)
        {
            string objToRetreive = "";
            switch (obj.ToLower())
            {
                case "boat":
                    objToRetreive = "dbo.Boat";
                    break;
                case "timeslot":
                    objToRetreive = "dbo.TimeSlot";
                    break;
                case "customer":
                    objToRetreive = "dbo.Customer";
                    break;
                default:
                    throw new Exception("Unknown object type");
            }
            
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM " + objToRetreive;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, CONNECTION_STRING);
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }

        private List<TimeSlot> getAllTimeSlots(DateTime date)
        {
            List<TimeSlot> timeSlots = new List<TimeSlot>();
            
            try
            {
                DataTable dt = this.runCustomerQuery("SELECT * FROM dbo.TimeSlot WHERE day = '" + date.Date.ToString("yyyy-MM-dd") + "'");

                foreach (DataRow dataRow in dt.Rows)
                {
                    DateTime day = (DateTime)dataRow["day"];
                    DateTime startTime = (DateTime)dataRow["startTime"];
                    DateTime endTime = (DateTime)dataRow["endTime"];
                    int boatNr = (int)dataRow["boatNr"];
                    int customerId = (int)dataRow["customerId"];

                    TimeSlot timeSlot = new TimeSlot(day, startTime, endTime, boatNr, customerId);
                    timeSlot.Id = int.Parse(dataRow["Id"].ToString());

                    timeSlots.Add(timeSlot);
                }
                
                return timeSlots;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        

        public double getTotalTurnover(DateTime day)
        {
            List<TimeSlot> date = this.getAllTimeSlots(day);
            double totalTurnover = 0;

            foreach (TimeSlot timeSlot in date)
            {
                totalTurnover += (timeSlot.getDuration() * timeSlot.Boat.HourlyRentalPrice);
            }

            return totalTurnover;
        }

        public double getTotalRentalTime(DateTime day)
        {
            List<TimeSlot> date = this.getAllTimeSlots(day);
            double totalRentalTime = 0;

            foreach (TimeSlot timeSlot in date)
            {
                totalRentalTime += timeSlot.getDuration();
            }

            return totalRentalTime;
        }

        public double getBoatDamage(DateTime day)
        {
            List<TimeSlot> date = this.getAllTimeSlots(day);
            int boatNr = 0;
            int damagedBoatNr = 0;

            foreach (TimeSlot timeSlot in date)
            {
                boatNr++;
                if (timeSlot.Boat.Damage > 0)
                {
                    damagedBoatNr++;
                }
            }

            try
            {
                return damagedBoatNr * 100 / boatNr;
            }
            catch (DivideByZeroException e) 
            {
                return 0;
            }
        }

        public Boat getRentedShortestTimeBoat(DateTime day)
        {
            List<TimeSlot> date = this.getAllTimeSlots(day);
            if (!dateIsEmpty(date))
            {
                TimeSlot shortestTimeBoat = date[0];
                foreach (TimeSlot timeSlot in date)
                {
                    if (timeSlot.getDuration() < shortestTimeBoat.getDuration())
                    {
                        shortestTimeBoat = timeSlot;
                    }
                }

                return shortestTimeBoat.Boat;
            }
            else
            {
                // If the list is empty (does not contain any timeslots), return null
                return null;

            }
        }

        // Return format: [boatNr, fuelConsumption]
        public double[] getBoatNrHighestFuelConsumption(DateTime day)
        {
            List<TimeSlot> date = this.getAllTimeSlots(day);
            if (!dateIsEmpty(date))
            {
                double[] boatNrHighestFuelConsumption = new double[2] { date[0].Boat.BoatNr, date[0].FuelConsumption };
                foreach (TimeSlot timeSlot in date)
                {
                    if (timeSlot.FuelConsumption > boatNrHighestFuelConsumption[1])
                    {
                        boatNrHighestFuelConsumption[0] = timeSlot.Boat.BoatNr;
                        boatNrHighestFuelConsumption[1] = timeSlot.FuelConsumption;
                    }
                }

                return boatNrHighestFuelConsumption;
            }
            else
            {
                return null;
            }
        }

        private bool dateIsEmpty(List<TimeSlot> date)
        {
            return date.Count == 0;
        }
    }
}
