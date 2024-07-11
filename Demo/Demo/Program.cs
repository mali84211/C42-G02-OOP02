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

            #region 4
            //Car c1;

            //c1 = new Car();
            //Console.WriteLine(c1);

            //Car C1 = new Car(10, "BMW", 290);
            //Console.WriteLine(C1);  

            //Car C2 = new Car(20,"BYD");
            //Console.WriteLine(C2);

            //Car C3 = new Car(30);
            //Console.WriteLine(C);

            #endregion
            #region 5
            //parent p = new Parent(1,2);
            //Console.WriteLine(p);
            //Console.WriteLine(P.product());

            //child c=new child(1,2,3);
            //Console.WriteLine(c.tostring());
            //Console.WriteLine(c.prouduct());
            #endregion
            #region 6
            //TaypA ObjA=new TaypA();
            //ObjA.x = 10;//invalid
            //ObjA.y = 20;//invalid       [PRIVATE]
            //ObjA.m = 30;//invalid

            //ObjA.Z = 40;//invalid         [INTERNAL]  

            //TaypB ObjB = new TaypB();
            //ObjB.X=10//INVALID

            #endregion
        }
    }
}
