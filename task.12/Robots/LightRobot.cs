using System;
using System.Collections.Generic;
using System.Text;

namespace task._12.Robots
{
    public class LightRobot : Robot
    {
        string Name;
        public override int Carrying => 50;


        public LightRobot(string name)
        {
            Name = name;
        }
    }
}
