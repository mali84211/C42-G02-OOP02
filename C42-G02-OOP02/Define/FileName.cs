using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C42_G02_OOP02.Program;

namespace C42_G02_OOP02.Define
{
    #region -1
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    #endregion
    #region -2
    internal struct Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person1(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    #endregion

    #region part3 -1
    public class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }

        public Employee(int id, string name, int securityLevel, decimal salary, DateTime hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }
    #endregion
    #region -2
    public class HiringDate
    {

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
    }

    public class Employee1
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public int SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public string Gender { get; set; }

       
        public Employee1(int id, string name, int securityLevel, decimal salary, HiringDate hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        // Method to display employee details
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Hire Date: {HireDate}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }
    #endregion

    #region 3
    public class HiringDate1
    {
        
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

       
        public HiringDate1(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
    }

    public class Employee2
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public int SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate1 HireDate { get; set; }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
            }
        }

   
        public Employee2(int id, string name, int securityLevel, decimal salary, HiringDate1 hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender; 
        }

       
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Hire Date: {HireDate}");
            Console.WriteLine($"Gender: {Gender}");
        }

       
        
    }

    #endregion
    #region 4
    public class HiringDate2
    {
       
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate2(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
    }

    public class Employee3
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate2 HireDate { get; set; }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
            }
        }

        public Employee3(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate2 hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender; 
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Hire Date: {HireDate}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }
    #endregion

}
