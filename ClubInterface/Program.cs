using System;

namespace FUNFUNFUFNU
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }
    class newClass : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string newField1;
        public string newField2;
        public string newField3;

        public newClass()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
            newField1 = "";
            newField2 = "";
            newField3 = "";
        }

        public newClass(int ID, string FIRSTNAME, string LASTNAME, string NEWFIELD1, string NEWFIELD2, string NEWFIELD3)
        {
            Id = ID;
            FirstName = FIRSTNAME;
            LastName = LASTNAME;
            newField1 = NEWFIELD1;
            newField2 = NEWFIELD2;
            newField3 = NEWFIELD3;
        }
        public void displayData()
        {
            Console.WriteLine("[ ! ] Display Data [ ! ]");
            Console.WriteLine(Id);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(newField1);
            Console.WriteLine(newField2);
            Console.WriteLine(newField3);
        }
        public string Fullname()
        {
            return Fullname();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            newClass newClassObject = new newClass(5,"firstname","lastname","234","5435","3434534345");
            newClassObject.displayData();
        }
    }
}