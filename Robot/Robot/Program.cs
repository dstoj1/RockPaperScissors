using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Male One = new Male("Sam", 50, 80);
            Male Two = new Male("DJ", 40, 40);
            Male[] MaleDancers = { One, Two };

            Female Three = new Female("Sara", 35, 20);
            Female Four = new Female("Debbie", 49, 35);
            Female[] FemaleDancers = {Three, Four};

           


            DanceInstruction danceFloor = new DanceInstruction();
            danceFloor.DanceMoves(Three, One);

            Console.ReadLine();
           

           // Console.WriteLine("Before lose charge", One.PowerLevel);
            //One.LoseCharge();
            //int currentCharge = One.PowerLevel;

            //Console.WriteLine("After lose charge", One.PowerLevel);
                

        } 
    }
}
