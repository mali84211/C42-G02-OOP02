using System.Text.RegularExpressions;  
using System;
using C42_G02_OOP02.Define;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Claims;

namespace C42_G02_OOP02
{

    internal class Program
    {
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }
        static void Main(string[] args)
        {
            #region part1
            //AT DEMO
            //        What You Can Write Inside The Class
            // 1.Attributes[Fields] => Member Variable
            // 2.Functions[Constructor, Getter Setter, Method]
            //3.Properties[Full Property, Automatic Property, Indexer]
            //4.Events
            // If There is no User defined Constructor, Compiler Will Always Generate Empty Parameterless constructor => Will do Nothing
            //If You defined a User defined Constructor ,  Compiler Will No Longer Generate Empty Parameterless constructor


            //Class VS Struct

            //Class:                                                   Struct:     
            //Reference Type                                            Value Type                     
            //Support 4 Pillars Of OOP                                  Support Encapsulation and Overloading in Polymorphism
            //More Flexible                                             If You Defined a user defined Constructor ,  Compiler Will always Generate Parameterless Constructor        
            //Does Support Inheritance                                  Doesn’t Support Inheritance           
            //6 Access Modifier Allowed Inside It                       3 Access Modifier Allowed Inside It        
            #endregion

            #region part2 -1
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] people = new Person[3];
            people[0] = new Person("ALi", 26);
            people[1] = new Person("Amr", 25);
            people[2] = new Person("Mona", 30);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            #endregion

            #region -2
            // Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person1[] people1 = new Person1[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter the name of person {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the age of person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                people1[i] = new Person1(name, age);

                Person1 oldestPerson = people1[0];

                for (int j = 1; j < people1.Length; j++)
                {
                    if (people1[j].Age > oldestPerson.Age)
                    {
                        oldestPerson = people1[j];
                    }
                }
                Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}.");
            }
            #endregion
            Console.WriteLine("========================");
            #region part3 -1
            //Design and implement a Class for the employees in a company:
            //Employee is identified by an ID, Name, security level, salary, hire date and Gender.

            Employee emp1 = new Employee(1, "ali", 5, 9000, new DateTime(1999, 5, 1), "Male");
            Employee emp2 = new Employee(2, "mona", 7, 7500, new DateTime(2000, 3, 15), "Female");
            Console.WriteLine("Employee 1 Details:");
            emp1.DisplayEmployeeInfo();
            Console.WriteLine("\nEmployee 2 Details:");
            emp2.DisplayEmployeeInfo();

            #endregion
            Console.WriteLine("========================");
            #region -2
            //Develop a Class to represent the Hiring Date Data:
            //consisting of fields to hold the day, month and Years.

            HiringDate hireDate1 = new HiringDate(1, 5, 1999);
            Employee1 emp3 = new Employee1(1, "ali", 5, 9000, hireDate1, "Male");
            HiringDate hireDate2 = new HiringDate(15, 3, 2000);
            Employee1 emp4 = new Employee1(2, "mona", 7, 7500, hireDate2, "Female");
            Console.WriteLine("Employee 3 Details:");
            emp1.DisplayEmployeeInfo();
            Console.WriteLine("\nEmployee 4 Details:");
            emp2.DisplayEmployeeInfo();
            #endregion
            Console.WriteLine("========================");
            #region 3
            //We need to restrict the Gender field to be only M or F [Male or Female] 
            try
            {
                
                HiringDate1 hireDate3 = new HiringDate1(1, 5, 1999);
                Employee2 emp5 = new Employee2(1, "ali", 5, 9000, hireDate3, "M");

                HiringDate1 hireDate4 = new HiringDate1(15, 3, 2000);
                Employee2 emp6 = new Employee2(2, "mona", 7, 7500, hireDate4, "F");

                Console.WriteLine("Employee 5 Details:");
                emp5.DisplayEmployeeInfo();
                Console.WriteLine("\nEmployee 6 Details:");
                emp6.DisplayEmployeeInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion
             Console.WriteLine("========================");
            #region -4
            try
            {

                HiringDate2 hireDate5 = new HiringDate2(1, 5, 1999);
                Employee3 emp7 = new Employee3(1, "ali", SecurityLevel.Developer, 9000, hireDate5, "M");

                HiringDate2 hireDate6 = new HiringDate2(15, 3, 2000);
                Employee3 emp8 = new Employee3(2, "mona", SecurityLevel.Secretary, 7500, hireDate6, "F");

                Console.WriteLine("Employee 7 Details:");
                emp7.DisplayEmployeeInfo();
                Console.WriteLine("\nEmployee 8 Details:");
                emp8.DisplayEmployeeInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion

        }



    }


    
}

