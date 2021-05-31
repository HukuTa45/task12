using System;
using System.Collections.Generic;
using System.Text;

namespace task._12.Robots
{
    public class HeavyRobot : Robot
    {
        public string Name;
        public override int Carrying => 100;

        public HeavyRobot(string name)
        {
            Name = name;
        }
    }
}
