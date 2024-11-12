using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_och_Polis
{
    internal class Person
    {
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string Diraction { get; set; 

        public Person() 
        {
            Name = GetRandomName();
            PositionX = GetStartPosition();
            PositionY = GetStartPosition();
            Diraction = GetStartDiraction();

        }
        public static void SayHello()
        {
            Console.WriteLine("Hi my name is ", Name, ". I am at", PositionX, " , ", PositionY,
                " and i am going ", Diraction);
        }
        public static int GetStartPosition()
        {
            //Function Generating random x or y value. 
            return 0;
        }
        public static string GetStartDiraction();
        {
            return "Right";
        }
   

    class Theif : Person
    {
        public List<string> StolenItems { get; set; }

        public bool Arrested { get; set; }

    }
    class Cizents : Person
    {
        public List<string> Possessions { get; set; }
    }

   
    class Police
    {
        public List<string> SeizedItems { get; set; }

    }

}


