using DAO;
using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Server;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        HomeController homeController = new HomeController();
        public bool startWork(GeneralContracts.OPERATION opCode, ref HouseHold houseHold)
        {
            return homeController.startWork(opCode, ref houseHold);
        }


        public bool startWork(GeneralContracts.OPERATION opCode, ref Person person)
        {
            return homeController.startWork(opCode, ref person);
        }

        
        public bool startWork(GeneralContracts.OPERATION opCode, ref List<HouseHold> houseHolds, HouseHold houseHold)
        {
            return homeController.startWork(opCode, ref houseHolds, houseHold);
        }


        public bool startWork(GeneralContracts.OPERATION opCode, ref List<Person> persons, HouseHold household)
        {
            return homeController.startWork(opCode, ref persons, household);
        }
        
        
    }
}
