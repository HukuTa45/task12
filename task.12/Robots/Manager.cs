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
        string robotName;
        public Storage storage = new Storage();

        public void HeavyRobotCreate() {
            int count = analyzer.heavyQueue.ProductHeavyQueue.Count;

            for (int i = 0; i<count; i++)
            {
                robotName = "heavyRobot_" + i;

                new HeavyRobot(robotName);
             
                Console.WriteLine($"Робот {robotName} был создан и забрал из очереди товар весом {analyzer.heavyQueue.ProductHeavyQueue.Peek().Weight} на склад");
                storage.Add(analyzer.heavyQueue.ProductHeavyQueue.Peek());
    
                analyzer.heavyQueue.ProductHeavyQueue.Dequeue();               
            }
        }

        public void LigtRobotCreate()
        {
            int count = analyzer.lightQueue.ProductLightQueue.Count;
            for (int i = 0; i < count; i++)
            {
                robotName = "lightRobot_" + i;

                new HeavyRobot(robotName);

                Console.WriteLine($"Робот {robotName} был создан и забрал из очереди товар весом {analyzer.lightQueue.ProductLightQueue.Peek().Weight} на склад");
                storage.Add(analyzer.lightQueue.ProductLightQueue.Peek());
                analyzer.lightQueue.ProductLightQueue.Dequeue();                
            }
        }
    }
}
