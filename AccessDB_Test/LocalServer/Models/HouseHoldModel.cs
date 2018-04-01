using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace Models
{
    class HouseHoldModel
    {
        public bool read(ref HouseHold houseHold)
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
        public bool add(HouseHold houseHold)
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

        public bool update(HouseHold houseHold)
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

        public bool delete(HouseHold houseHold)
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


        public bool search(ref List<HouseHold> houseHolds)
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
