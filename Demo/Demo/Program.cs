namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1

            //Employee employee = new Employee(10,"ali",2233);
            //Console.WriteLine(employee);
            //id = 10;
            //name = "ali";
            //salary = 2233;


            //employee.id = 20;   //set id directly through attribute
            //Console.WriteLine(employee.id);    //get id directly through attribute    

            //employee.name = "mona";
            //Console.WriteLine(employee.name);

            //employee.SetName("mona");
            //Console.WriteLine(employee.GetName());

            //employee.salary = 1000;
            //Console.WriteLine(employee.salary);

            //employee.salary = 2000;
            //Console.WriteLine(employee.salary);

            //employee.age = 30;

            #endregion

            #region V2
            //string[] Name;
            //int[] Numbers;
            //int[] Size;


            //Public int Size{

            //    get     { return Size; }
            //    set{ Size = Value; }
            //}

            //phonebook Note = new phonebook();
            //Note.AddPerson(0,"ali",123);
            //Note.AddPerson(1,"amr",456);
            //Note.AddPerson(2,"mona",798);

            //int monaNumber = Note.GetPersonNumber("Mona");
            //Console.WriteLine(monaNumber==-1 ? "Person not found" : monaNumber);
            //Note.SetPersonNumber("mona",999);

            //VEDIO 3


            //phonebook["mona"] = 999;
            //Console.WriteLine(phonebook["mona"]);


            //Console.WriteLine(Note["mona"]);
            //Note["mona"] = 999;
            //Console.WriteLine(Note["mona"]);

            //string Name = "ali";
            //Console.WriteLine(Name[0]);

            //Name[0] = 'b'; //invalid


            //for (int i = 0; i < Note.Size; i++) {
            //    Console.WriteLine(Note[i]);

            //}
            #endregion
        }
    }
}
