using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Models;

namespace Controllers
{
    class HouseHoldController
    {
        private HouseHoldModel houseHoldModel = new HouseHoldModel();

        public bool read(ref HouseHold houseHold)
        {
            try
            {
                return houseHoldModel.read(ref houseHold); ;
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
                return houseHoldModel.add(houseHold);
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
                return houseHoldModel.update(houseHold);
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
                return houseHoldModel.delete(houseHold); ;
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
                return houseHoldModel.search(ref houseHolds); ;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

    }
}
