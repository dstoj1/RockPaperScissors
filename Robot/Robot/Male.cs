using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Male : Robot
    {
   
            public Male(string name, int age, int PowerLevel)
        {
            Name = name;
            Age = age;
            this.PowerLevel = PowerLevel;
        }
    }
}
