using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Access
{
    private String connectionString = @"Provider=Microsoft.JET.OlEDB.4.0;"
                       + @"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "LocalStorage.accdb";
    public bool testConnection()
    {
        try
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
            }

            return true;
        }
        catch (Exception ex)
        {
            Log.writeToLog("testConnection", ex.StackTrace, ex.Message);
            return false;
        }
    }

    public bool executeCommand(string commandString, ref List<string> result)
    {
        try
        {
                DataSet ds = new DataSet();
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    OleDbDataAdapter da = new OleDbDataAdapter(commandString, conn);
                    da.Fill(ds);
                    conn.Close();
                    DataTable dt = ds.Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (string value in row.ItemArray)
                        {
                            result.Add(value);
                        }
                    }
                }           
           
            return true;
        }
        catch (Exception ex)
        {
            Log.writeToLog("testConnection", ex.StackTrace, ex.Message);
            return false;
        }
    }

    public bool executeCommand(string commandString)
    {
        try
        {

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(commandString, conn);
                command.ExecuteNonQuery();
            }

            return true;
        }
        catch (Exception ex)
        {
            Log.writeToLog("testConnection", ex.StackTrace, ex.Message);
            return false;
        }
    }



}

