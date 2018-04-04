using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using General;
using DAO;
using Database;

namespace Models
{
    class HouseHoldModel
    {
        private OracleDB db = new OracleDB();
        private const int RESULT_DEFAULT_SIZE = 0;
        private const int PROPERTIES_SIZE = 13;
        private const string HH_SEQ_NAME = "HOUSEHOLD_SEQ";

        public bool read(ref HouseHold houseHold)
        {
            string query;
            string[] result;
            bool executionResult;
            try
            {
                query = "SELECT NAME,AREA,LOCATION,BEBEFICIARY,HOSTONG_DIS,ADDRESS,MARTIAL_STATUS,DISPLACEMENT_STATUS" +
                    ",RETURNEE_STATUS,SHELTER_STATUS,INCOME,ORIGINAL_GOVERNORATE,PARTNER FROM HOUSESOLD WHERE ID=" + houseHold.Id;
                result = new string[RESULT_DEFAULT_SIZE];

                executionResult = db.executeCommand(query, ref result);
                if (executionResult)
                {
                    if (result.Length < PROPERTIES_SIZE)
                    {
                        houseHold.Name = result[0];
                        houseHold.Area = Convert.ToInt32(result[1]);
                        houseHold.Location = Convert.ToInt32(result[2]);
                        houseHold.BeneficiaryType = Convert.ToInt32(result[3]);
                        houseHold.HostingDisplacedPeople = Convert.ToInt32(result[4]);
                        houseHold.Address = result[5];
                        houseHold.MartialStatus = Convert.ToInt32(result[6]);
                        houseHold.DisplacementStatus = Convert.ToInt32(result[7]);
                        houseHold.ReturneeStatus = Convert.ToInt32(result[8]);
                        houseHold.ShelterStatus = Convert.ToInt32(result[9]);
                        houseHold.Income = Convert.ToInt32(result[10]);
                        houseHold.OriginalGovernorate = Convert.ToInt32(result[11]);
                        houseHold.Partner = Convert.ToInt32(result[12]);
                    }
                }
                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
        public bool add(HouseHold houseHold)
        {
            string query;
            bool executionResult;
            int id = 0;
            try
            {
                executionResult = db.getNewID(HH_SEQ_NAME, ref id);
                if (executionResult)
                {
                    query = "INSERT INTO HOUSEHOLD VALUES(" + id + "," + GeneralContracts.prepareStringForDb(houseHold.Name) +
                        "," + houseHold.Area + "," + houseHold.Location + "," + houseHold.BeneficiaryType + "," + houseHold.HostingDisplacedPeople +
                        "," + GeneralContracts.prepareStringForDb(houseHold.Address) + "," + houseHold.MartialStatus + "," + houseHold.DisplacementStatus +
                        "," + houseHold.ReturneeStatus + "," + houseHold.ShelterStatus + "," + houseHold.Income + "," + houseHold.OriginalGovernorate +
                        "," + houseHold.Partner + ")";

                    executionResult = db.executeCommand(query);
                }
                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool update(HouseHold houseHold)
        {
            string query;
            bool executionResult;
            try
            {
                query = "UPDATE HOUSEHOLD SET NAME=" + GeneralContracts.prepareStringForDb(houseHold.Name) +
                    ",AREA=" + houseHold.Area + ",LOCATION" + houseHold.Location + ",BEBEFICIARY=" + houseHold.BeneficiaryType + ",HOSTONG_DIS=" + houseHold.HostingDisplacedPeople +
                    ",ADDRESS=" + GeneralContracts.prepareStringForDb(houseHold.Address) + ",MARTIAL_STATUS=" + houseHold.MartialStatus + ",DISPLACEMENT_STATUS=" + houseHold.DisplacementStatus +
                    ",RETURNEE_STATUS=" + houseHold.ReturneeStatus + ",SHELTER_STATUS=" + houseHold.ShelterStatus + ",INCOME=" + houseHold.Income + ",ORIGINAL_GOVERNORATE=" + houseHold.OriginalGovernorate +
                    ",PARTNER=" + houseHold.Partner + " WHERE ID=" + houseHold.Id + ")";

                executionResult = db.executeCommand(query);

                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool delete(HouseHold houseHold)
        {
            string query;
            bool executionResult;
            try
            {

                query = "DELETE FROM HOUSEHOLD WHERE ID = " + houseHold.Id;

                executionResult = db.executeCommand(query);

                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }


        public bool search(ref List<HouseHold> houseHolds, HouseHold houseHold)
        {
            string query;
            bool executionResult;

            try
            {
                query = "SELECT * FROM HOUSEHOLD WHERE ";
               query += getFilters(houseHold);

                executionResult = db.executeCommand(query);

                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public string getFilters(HouseHold houseHold)
        {
            string whereStatment = "";
            try
            {

                return whereStatment;               
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return string.Empty;
            }
        }
    }
}
