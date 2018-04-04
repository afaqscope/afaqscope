using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Person
    {
        #region "Privates"
        private int id;
        private int houseHoldId;
        private int role;
        private int beneficiary;
        private int recipient;
        private string firstName;
        private string midName;
        private string lastName;
        private int gender;
        private int dateOfBirthType;
        private DateTime dateOfBirth;
        private int documentType;
        private string documentNumber;
        private string mobilePhone;
        private string homePhone;
        private int hieght;
        private int weight;
        private int muac;
        private string malnourished;
        private int physicalDisability;
        private int mintalDisability;
        private int chronicallyIll;
        private int disabled;
        private string fingerPrint1;
        private string fingerPrint2;
        private string fingerPrint3;
        private string fingerPrint4;
        #endregion

        #region "Properties"
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value; }
        }

        public int Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MidName
        {
            get { return midName; }
            set { midName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int DateOfBirthType
        {
            get { return dateOfBirthType; }
            set { dateOfBirthType = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public int DocumentType
        {
            get { return documentType; }
            set { documentType = value; }
        }

        public string DocumentNumber
        {
            get { return documentNumber; }
            set { documentNumber = value; }
        }
        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public int Hieght
        {
            get { return hieght; }
            set { hieght = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int MUAC
        {
            get { return muac; }
            set { muac = value; }
        }

        public string Malnourished
        {
            get { return malnourished; }
            set { malnourished = value; }
        }

        public int PhysicalDisability
        {
            get { return physicalDisability; }
            set { physicalDisability = value; }
        }

        public int MintalDisability
        {
            get { return mintalDisability; }
            set { mintalDisability = value; }
        }

        public int ChronicallyIll
        {
            get { return chronicallyIll; }
            set { chronicallyIll = value; }
        }
        public int Disabled
        {
            get { return disabled; }
            set { disabled = value; }
        }
        public string FP1
        {
            get { return fingerPrint1; }
            set { fingerPrint1 = value; }
        }

        public string FP2
        {
            get { return fingerPrint2; }
            set { fingerPrint2 = value; }
        }

        public string FP3
        {
            get { return fingerPrint3; }
            set { fingerPrint3 = value; }
        }

        public string FP4
        {
            get { return fingerPrint4; }
            set { fingerPrint4 = value; }
        }

        public int HouseHoldId
        {
            get { return houseHoldId; }
            set { houseHoldId = value; }
        }
        #endregion
    }
}
