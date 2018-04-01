using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace Models
{
    class PersonModel
    {
        public bool read(ref Person person)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
        public bool add(Person person)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool update(Person person)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool delete(Person person)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }


        public bool search(ref List<Person> houseHolds)
        {
            try
            {
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
