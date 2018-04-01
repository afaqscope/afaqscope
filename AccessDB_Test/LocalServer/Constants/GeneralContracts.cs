using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public class GeneralContracts
    {
        public enum TYPE
        {
            HouseHold,
            Person
        }

        public enum OPERATION
        {
            read,
            add,
            update,
            delete,
            search
        }
    }
}
