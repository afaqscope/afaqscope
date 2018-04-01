using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Models;

namespace Controllers
{
    class PersonController
    {
        private PersonModel PersonModel = new PersonModel();

        public bool read(ref Person person)
        {
            try
            {
                return PersonModel.read(ref person); ;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
        public bool add(Person person)
        {
            try
            {
                return PersonModel.add(person);
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }

        public bool update(Person person)
        {
            try
            {
                return PersonModel.update(person);
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
        public bool delete(Person person)
        {
            try
            {
                return PersonModel.delete(person); ;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
        public bool search(ref List<Person> persons)
        {
            try
            {
                return PersonModel.search(ref persons); ;
            }
            catch (Exception ex)
            {
                Log.writeToLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.StackTrace, ex.Message);
                return false;
            }
        }
    }
}
