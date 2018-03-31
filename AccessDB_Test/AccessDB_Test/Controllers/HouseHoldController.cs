using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessDB_Test.DAO;
using AccessDB_Test.Models;

namespace AccessDB_Test.Controllers
{
    class HouseHoldController
    {
        private HouseHoldModel houseHoldModel = new HouseHoldModel();
    public bool add(HouseHold houseHold)
        {
            try
            {
                return houseHoldModel.add(houseHold);
            }
            catch (Exception ex)
            {
                Log.writeToLog("add", ex.StackTrace, ex.Message);
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
            Log.writeToLog("update", ex.StackTrace, ex.Message);
            return false;
        }
    }

        public bool read(ref HouseHold houseHold)
        {
            try
            {
                return  houseHoldModel.read(ref houseHold);;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
    }
}
