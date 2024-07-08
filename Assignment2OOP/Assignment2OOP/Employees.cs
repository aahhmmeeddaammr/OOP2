using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2OOP
{
    #region GenderEnum
    enum Gender
    {
        M, F
    } 
    #endregion

    #region HireDateClass
    class HireDate
    {
        public string day { get; set; }
        public string month { get; set; }

        public string year { get; set; }

        public override string ToString()
        {
            return string.Format("{0} / {1} / {2}", day, month, year);
        }
        public HireDate(string day, string month, string year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    } 
    #endregion

    #region securityLevelEnum
    [Flags]
    enum securityLevel : byte
    {
        guest = 1, Developer = 2, secretary = 4, DBA = 8 
    } 
    #endregion

    internal class Employee
    {

        #region Class Variables
        private int Id;
        private String name;
        private float salary;
        private Gender gender; 
        public HireDate hireDate { get; set; }
        private securityLevel securityLevel;
        #endregion

        #region Constructor
        public Employee(int _id , string _name , float _Salary , Gender _gender , HireDate _hireDate , securityLevel _securtylivel )
        {
            Id = _id;
            name = _name;
            salary = _Salary;
            gender = _gender;
            hireDate = _hireDate;
            securityLevel = _securtylivel;
        }
        #endregion

        #region Override Functions
        public override string ToString()
        {
            string outg = "Female";
            if(this.gender == Gender.M)
            {
                outg = "Male";
            }
            return string.Format("\tYOUR ID: {0} \n\tYOUR NAME: {1} \n\tYOUR HIRING DATE: {2} \n\tYOUR SALARY: {3} \n\tYOUR GENDER: {4} \n\tYOUR SECURITY LEVEL: {5}", Id, name, hireDate.ToString(), salary, outg, securityLevel);
        }
        #endregion

        #region setters and getters
        public int GetID()
        {
            return Id;
        }
        public string GetName()
        {
            return name;
        }
        public float GetSalary()
        {
            return salary;
        }
        public Gender GetGender()
        {
            return gender;
        }
        public securityLevel GetSecurityLevel()
        {
            return securityLevel;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setGender(string gender)
        {
            try
            {
                bool flag = Enum.TryParse<Gender>(gender, out this.gender);
                if (!flag)
                {
                    throw new Exception("Invalid data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void setHireDate(HireDate date)
        {
            hireDate = date;
        }
        public bool HasSecurityLevel(securityLevel securityLevel)
        {
            if ((this.securityLevel & securityLevel) == securityLevel)
            {
                return true;
            }
            return false;
        }

        public void AddNewSecurityLevel(securityLevel securityLevel)
        {
            this.securityLevel |= securityLevel;
        } 
        #endregion

    }
}
