using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Database;
using General;
namespace Models
{
    class PersonModel
    {
        private OracleDB db = new OracleDB();
        private const int RESULT_DEFAULT_SIZE = 0;
        private const int PROPERTIES_SIZE = 13;
        private const string P_SEQ_NAME = "PERSON_SEQ";

        public bool read(ref Person person)
        {
            string query;
            string[] result;
            bool executionResult;
            try
            {
                query = "SELECT HOUSEHOLD_NAME,HOUSEHOLD_ID, ROLE , " +
                    "BEBEFICIARY,RECIPIENT ,FIRST_NAME ,MID_NAME ,LAST_NAME ,GENDER ,DOB_TYPE ,DOB ," +
                    "DOCUMENT_TYPE ,DOCUMENT_NUMBER ,MOBILE_PHONE ,HOME_PHONE ,HIEGHT ,WEIGHT ,UAC ," +
                    " MALNOURISHED ,PHYSICAL_DISABILITY,MINTAL_DISABILITY ,CHRONICALLY_ILL ,DISABLED " +
                    "FROM PERSON WHERE ID=" + person.Id;
                result = new string[RESULT_DEFAULT_SIZE];

                executionResult = db.executeCommand(query, ref result);
                if (executionResult)
                {
                    if (result.Length < PROPERTIES_SIZE)
                    {
                        person.HouseHoldName = result[0];
                        person.HouseHoldId = Convert.ToInt32(result[1]);
                        person.Role = Convert.ToInt32(result[2]);
                        person.Beneficiary = Convert.ToInt32(result[3]);
                        person.Recipient = Convert.ToInt32(result[4]);
                        person.FirstName = result[5];
                        person.MidName = result[6];
                        person.LastName = result[7];
                        person.Gender = Convert.ToInt32(result[8]);
                        person.DateOfBirthType = Convert.ToInt32(result[9]);
                        person.DateOfBirth = DateTime.Parse(result[10]);
                        person.DocumentType = Convert.ToInt32(result[11]);
                        person.DocumentNumber = result[12];
                        person.MobilePhone = result[13];
                        person.HomePhone = result[14];
                        person.Hieght = Convert.ToInt32(result[15]);
                        person.Weight = Convert.ToInt32(result[16]);
                        person.MUAC = Convert.ToInt32(result[17]);
                        person.Malnourished = result[18];
                        person.PhysicalDisability = Convert.ToInt32(result[19]);
                        person.MintalDisability = Convert.ToInt32(result[20]);
                        person.ChronicallyIll = Convert.ToInt32(result[21]);
                        person.Disabled = Convert.ToInt32(result[22]);

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
        public bool add(Person person)
        {
            string query;
            bool executionResult;
            int id = 0;
            try
            {
                executionResult = db.getNewID(P_SEQ_NAME, ref id);
                if (executionResult)
                {
                    query = "INSERT INTO PERSON(" + "ID,HOUSEHOLD_NAME,HOUSEHOLD_ID, ROLE " +
                    "BEBEFICIARY,RECIPIENT ,FIRST_NAME ,MID_NAME ,LAST_NAME ,GENDER ,DOB_TYPE ,DOB ," +
                    "DOCUMENT_TYPE ,DOCUMENT_NUMBER ,MOBILE_PHONE ,HOME_PHONE ,HIEGHT ,WEIGHT ,MUAC ," +
                    "MALNOURISHED ,PHYSICAL_DISABILITY,MINTAL_DISABILITY ,CHRONICALLY_ILL ,DISABLED," +
                    "FP1,FP2,FP3,FP4" +
                        "VALUES(" + id + "," + GeneralContracts.prepareStringForDb(person.HouseHoldName) +
                        "," + person.HouseHoldId + "," + person.Role + "," + person.Beneficiary + "," + person.Recipient +
                        "," + GeneralContracts.prepareStringForDb(person.FirstName) + "," + GeneralContracts.prepareStringForDb(person.MidName) + "," + GeneralContracts.prepareStringForDb(person.LastName) +
                        "," + person.Gender + "," + person.DateOfBirthType + "," + person.DateOfBirth + "," + person.DocumentType +
                        "," + GeneralContracts.prepareStringForDb(person.DocumentNumber) + "," + GeneralContracts.prepareStringForDb(person.MobilePhone) + "," + GeneralContracts.prepareStringForDb(person.HomePhone) + "," + person.Hieght +
                        "," + person.Weight + "," + person.MUAC + "," + GeneralContracts.prepareStringForDb(person.Malnourished) + "," + person.PhysicalDisability +
                        "," + person.MintalDisability + "," + person.ChronicallyIll + "," + person.Disabled + "," + GeneralContracts.prepareStringForDb(person.FP1) +
                         GeneralContracts.prepareStringForDb(person.FP2) + "," + GeneralContracts.prepareStringForDb(person.FP3) + "," + GeneralContracts.prepareStringForDb(person.FP4) + ")";

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

        public bool update(Person person)
        {
            string query;
            bool executionResult;
            try
            {
                query = "UPDATE PERSON SET" + "HOUSEHOLD_NAME=" + GeneralContracts.prepareStringForDb(person.HouseHoldName) + ",HOUSEHOLD_ID=" + person.HouseHoldId + ", ROLE=" + person.Role +
                   ",BEBEFICIARY=" + person.Beneficiary + ",RECIPIENT=" + person.Recipient + ",FIRST_NAME=" + GeneralContracts.prepareStringForDb(person.FirstName) +
                   ",MID_NAME=" + GeneralContracts.prepareStringForDb(person.MidName) + ",LAST_NAME=" + GeneralContracts.prepareStringForDb(person.LastName) +
                   ",GENDER=" + person.Gender + ",DOB_TYPE" + person.DateOfBirthType + ",DOB=" + person.DateOfBirth +
                   ",DOCUMENT_TYPE=" + person.DocumentType + ",DOCUMENT_NUMBER=" + GeneralContracts.prepareStringForDb(person.DocumentNumber) + ",MOBILE_PHONE=" + GeneralContracts.prepareStringForDb(person.MobilePhone) +
                   ",HOME_PHONE=" + GeneralContracts.prepareStringForDb(person.HomePhone) + ",HIEGHT=" + person.Hieght + ",WEIGHT=" + person.Weight + ",MUAC=" + person.MUAC +
                   ",MALNOURISHED=" + person.Malnourished + ",PHYSICAL_DISABILITY=" + person.PhysicalDisability + ",MINTAL_DISABILITY=" + person.MintalDisability +
                   ",CHRONICALLY_ILL" + person.ChronicallyIll + ",DISABLED" + person.Disabled +
                   ",FP1=" + GeneralContracts.prepareStringForDb(person.FP1) + ",FP2" + GeneralContracts.prepareStringForDb(person.FP2) + ",FP3" + GeneralContracts.prepareStringForDb(person.FP3) + ",FP4" + GeneralContracts.prepareStringForDb(person.FP4) +
                   " WHERE ID = " + person.Id;
                executionResult = db.executeCommand(query);

                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool delete(Person person)
        {
            string query;
            bool executionResult;
            try
            {
                query = "DELETE FROM person WHERE ID = " + person.Id;

                executionResult = db.executeCommand(query);

                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }


        public bool search(ref List<Person> persons,HouseHold household)
        {
            string query;
            bool executionResult;
            try
            {
                query = "SELECT NAME,AREA,LOCATION,HOUSEHOLD_NAME, ROLE , " +
                    "BEBEFICIARY,RECIPIENT ,FIRST_NAME ,MID_NAME ,LAST_NAME ,GENDER ,DOB_TYPE ,DOB ," +
                    "DOCUMENT_TYPE ,DOCUMENT_NUMBER ,MOBILE_PHONE ,HOME_PHONE ,HIEGHT ,WEIGHT ,UAC ," +
                    " MALNOURISHED ,PHYSICAL_DISABILITY,MINTAL_DISABILITY ,CHRONICALLY_ILL ,DISABLED " +
                    "FROM HOUSEHOLD,PERSON WHERE PERSON.ID=HOUSEHOLD.ID AND HOUSEHOLD_ID = " + household.Id;

                executionResult = db.executeCommand(query);

                return executionResult;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
    }
}
