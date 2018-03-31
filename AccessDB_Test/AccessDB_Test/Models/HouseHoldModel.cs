using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Storage;
using AccessDB_Test.DAO;

namespace AccessDB_Test.Models
{
    class HouseHoldModel
    {
        private string jsonSettingsFile = AppDomain.CurrentDomain.BaseDirectory + "data.json";
        public bool add(HouseHold houseHold)
        {
            try
            {
                return true;
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
                return true;
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
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }

        private bool fillBeneficiaryTypeList(ref HouseHold houseHold)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }

        private bool fillhostingDisplacedPeopleList(ref HouseHold houseHold)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }

        private bool fillmartialStatusList()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
        private bool fillreturneeStatusList()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
        private bool fillshelterStatusList()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
        private bool fillincomeList()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
        private bool filloriginalGovernorateList()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
        private bool fillpartnerList()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("read", ex.StackTrace, ex.Message);
                return false;
            }
        }
    }
}
