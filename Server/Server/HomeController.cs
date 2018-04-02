using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;
using Controllers;
using General;

namespace Server
{
    //This class is the entry point of the server
    public class HomeController
    {
        private HouseHoldController houseHoldController;
        private PersonController personController;

        public HomeController()
        {
            houseHoldController = new HouseHoldController();
            personController = new PersonController();
        }

        public bool startWork(GeneralContracts.OPERATION opCode, ref HouseHold houseHold)
        {
            try
            {
                switch (opCode)
                {
                    case GeneralContracts.OPERATION.read:
                        return houseHoldController.read(ref houseHold);
                    case GeneralContracts.OPERATION.add:
                        return houseHoldController.add(houseHold);
                    case GeneralContracts.OPERATION.update:
                        return houseHoldController.update(houseHold);
                    case GeneralContracts.OPERATION.delete:
                        return houseHoldController.delete(houseHold);
                     default:
                          return false;
                }
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool startWork(GeneralContracts.OPERATION opCode, ref Person person)
        {
            try
            {
                switch (opCode)
                {
                    case GeneralContracts.OPERATION.read:
                        return personController.read(ref person);
                    case GeneralContracts.OPERATION.add:
                        return personController.add(person);
                    case GeneralContracts.OPERATION.update:
                        return personController.update(person);
                    case GeneralContracts.OPERATION.delete:
                        return personController.delete(person);
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool startWork(GeneralContracts.OPERATION opCode, ref List<HouseHold> houseHolds, HouseHold houseHold)
        {
            try {
                switch (opCode)
                {
                    case GeneralContracts.OPERATION.read:
                        return houseHoldController.search(ref houseHolds,houseHold);
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool startWork(GeneralContracts.OPERATION opCode, ref List<Person> persons)
        {
            try
            {
                switch (opCode)
                {
                    case GeneralContracts.OPERATION.read:
                        return personController.search(ref persons);
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
    }
}
