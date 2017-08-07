using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Robot
    {
        public int PowerLevel;
        public int Age;
        public string Name;

        public Robot()
        {

        }
        

        public void StartDance()
        {
            if (PowerLevel <= 50)
            {
                PowerLevel = 100;
            }
            else
            {
                Console.WriteLine("Start Dancing");
            }
        }
        public void Recharge()
        {
            PowerLevel += 10;
            Console.WriteLine("Recharging");
        }
        public void LoseCharge()
        {
            if (Age >= 45)
            {
                PowerLevel -= 20;
            }
            else
            {
                PowerLevel -= 10;
            }
            Console.WriteLine("Losing Charge");
        }
       public void Dance()
        {
            Console.WriteLine("Dancing");
            LoseCharge();

        }

     }     
}
        
    

