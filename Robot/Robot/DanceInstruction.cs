using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class DanceInstruction 
    {

         
        public DanceInstruction()
        {
            
        }
        public void DanceMoves(Female FemaleBot, Male MaleBot)
        {
            // FemaleBot.Dance();
            FemaleBot.StartDance();
            
                for (int i = 1; i <= 10; i++)
                {
                    if (FemaleBot.PowerLevel > 40)
                    {
                        FemaleBot.Dance();
                    }
                    else
                    {
                        FemaleBot.Recharge();
                    }
                Console.WriteLine(FemaleBot.Name + " " + FemaleBot.PowerLevel + " PowerLevel");
                }

            // MaleBot.Dance();
            MaleBot.StartDance();
                
                for (int i = 1; i <= 10; i++)
                {
                    if (MaleBot.PowerLevel > 40)
                    {
                        MaleBot.Dance();
                    }
                    else
                    {
                        MaleBot.Recharge();
                    }
                Console.WriteLine(MaleBot.Name + " " + MaleBot.PowerLevel + " PowerLevel");
            }
            // Console.WriteLine(FemaleBot.PowerLevel);
        }
    }
}
