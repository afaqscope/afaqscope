using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class OracleDB
    {
        private string connectionString = "User Id=system;Password=m6md11234;Data Source=oracle";
        public bool checkConnection(string command, ref string[] result)
        {
            try
            {
                OracleConnection con = new OracleConnection(connectionString);
                con.ConnectionString = "User Id=scott;Password=tiger;Data Source=oracle";
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
        public bool executeCommand(string queryString, ref string[] result)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    OracleCommand command = new OracleCommand(queryString, connection);
                    connection.Open();
                    OracleDataReader reader;
                    reader = command.ExecuteReader();
                    result = new string[10];
                    // Always call Read before accessing data.
                    while (reader.Read())
                    {
                        Array.Resize(ref result, reader.FieldCount);
                        for (int index = 0; index < reader.FieldCount - 1; index++)
                            result[index] = reader[index].ToString();
                    }

                    // Always call Close when done reading.
                    reader.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool executeCommand(string queryString)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    OracleCommand command = new OracleCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    commit();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool getNewID(string sequenceName, ref int result)
        {
            try
            {
                string queryString = "SELECT " + sequenceName + ".NEXTVAL FROM DUAL";
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    OracleCommand command = new OracleCommand(queryString, connection);
                    connection.Open();
                    OracleDataReader reader;
                    reader = command.ExecuteReader();

                    // Always call Read before accessing data.
                    while (reader.Read())
                    {
                       result = Convert.ToInt32(reader.GetString(1));
                    }

                    // Always call Close when done reading.
                    reader.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }


        public bool commit()
        {
            try
            {
                string queryString = "commit";
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    OracleCommand command = new OracleCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }


    }
}
