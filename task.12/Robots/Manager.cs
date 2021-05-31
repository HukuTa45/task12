using System;
using System.Collections.Generic;
using System.Text;
using task._12.ProductSort;
using task._12.ProductStorage;
using task._12.Robots;

namespace task._12
{
    public class Manager 
    {
        public Analyzer analyzer = new Analyzer();
        
        public void HeavyRobotCreate() {
            int count = analyzer.heavyQueue.ProductHeavyQueue.Count;

            for (int i = 0; i<count; i++)
            {
                string robotName = "heavyRobot_" + i;

                new HeavyRobot(robotName);

                Console.WriteLine($"Робот {robotName} был создан и забрал из очереди товар весом {analyzer.heavyQueue.ProductHeavyQueue.Peek().Weight}");

                analyzer.heavyQueue.ProductHeavyQueue.Dequeue();               
            }
        }

        public void LigtRobotCreate()
        {
            int count = analyzer.lightQueue.ProductLightQueue.Count;
            for (int i = 0; i < count; i++)
            {
                string robotName = "lightRobot_" + i;

                new HeavyRobot(robotName);

                Console.WriteLine($"Робот {robotName} был создан и забрал из очереди товар весом {analyzer.lightQueue.ProductLightQueue.Peek().Weight}");
                analyzer.lightQueue.ProductLightQueue.Dequeue();                
            }
        }
    }
}
