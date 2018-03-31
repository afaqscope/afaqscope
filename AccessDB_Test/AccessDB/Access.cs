using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Access
{
    private String connectionString = @"dsn=Access2;Dbq="
                       + @"" + AppDomain.CurrentDomain.BaseDirectory + "LocalStorage.accdb";
    public bool testConnection()
    {
        try

        {
            using (System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection(connectionString))
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

    public bool executeCommand(string commandString,ref List<Object> result)
    {
        try
        {
            using (System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection(connectionString))
            {
                conn.Open();
                OdbcCommand myCommand = new OdbcCommand("insert into Product(ProductName) values (\'hello\')", conn);
                myCommand.ExecuteNonQuery();
                 myCommand = new OdbcCommand(commandString, conn);

                 OdbcDataReader reader = myCommand.ExecuteReader();
                 object[] meta = new object[10];
                 bool read;
                 try
                 {
                     if (reader.Read() == true)
                     {
                         do
                         {
                             int NumberOfColums = reader.GetValues(meta);

                             for (int i = 0; i < NumberOfColums; i++)
                                 Console.Write("{0} ", meta[i].ToString());

                             Console.WriteLine();
                             read = reader.Read();
                         } while (read == true);
                     }
                 }
                 catch (Exception e)
                 { }
                finally
                {
                    reader.Close();
                    conn.Close();
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

            using (System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection(connectionString))
            {
                conn.Open();
                System.Data.Odbc.OdbcCommand command = new System.Data.Odbc.OdbcCommand(commandString, conn);
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

