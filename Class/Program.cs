using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();

            string myObj1 = myObj.model;
            int myObj2 = myObj.model1Speed;

            Console.WriteLine($"{myObj1} {myObj2}");


            Team teamObj = new Team();

            string newObj1 = teamObj.teamName1;
            int newObj2 = teamObj.drivers1;

            Console.WriteLine(newObj1 +" : " +  newObj2);

            Team teamObj2 = new Team();

            string new1 = teamObj.teamName2;
            int new2 = teamObj.drivers2;

            Console.WriteLine(new1 + " : " + new2);



        }
    }
}
