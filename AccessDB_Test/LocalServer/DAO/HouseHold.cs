using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class HouseHold
    {
        #region "Privates"

        private string name;
        private int area;
        private int location;
        private int beneficiaryType;
        private int hostingDisplacedPeople;
        private string address;
        private int martialStatus;
        private int displacementStatus;
        private int returneeStatus;
        private int shelterStatus;
        private int income;
        private int originalGovernorate;
        private int partner;

        #endregion

        #region "Properties"
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    
        public int Area
        {
            get { return area; }
            set { area = value; }
        }  
        
        public int Location
        {
            get { return location; }
            set { location = value; }
        }

        public int BeneficiaryType
        {
            get { return beneficiaryType; }
            set { beneficiaryType = value; }
        }

        public int HostingDisplacedPeople
        {
            get { return hostingDisplacedPeople; }
            set { hostingDisplacedPeople = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int MartialStatus
        {
            get { return martialStatus; }
            set { martialStatus = value; }
        }
        public int DisplacementStatus
        {
            get { return displacementStatus; }
            set { displacementStatus = value; }
        }

        public int ReturneeStatus
        {
            get { return returneeStatus; }
            set { returneeStatus = value; }
        }

        public int ShelterStatus
        {
            get { return shelterStatus; }
            set { shelterStatus = value; }
        }

        public int Income
        {
            get { return income; }
            set { income = value; }
        }

        public int OriginalGovernorate
        {
            get { return originalGovernorate; }
            set { originalGovernorate = value; }
        }

        public int Partner
        {
            get { return partner; }
            set { partner = value; }
        }

        #endregion
    }
}
