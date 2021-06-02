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
        private string _robotName;
        public Storage storage = new Storage();

        public void GetFromStorage(int id) {

            var weightTakenProduct = storage.Products[id];

            if (weightTakenProduct > 50)
            {
                _robotName = "Storage - HeavyRobot_" + id;
                new HeavyRobot(_robotName);
                Console.WriteLine($"Робот {_robotName} был создан и забрал товар #{id} весом {weightTakenProduct} со склада");
                storage.GetProduct(id);
            }
            else
            {
                _robotName = "Storage - LightRobot_" + id;
                new LightRobot(_robotName);
                Console.WriteLine($"Робот {_robotName} был создан и забрал товар #{id} весом {weightTakenProduct} со склада");
                storage.GetProduct(id);
            }

        }

        public void HeavyQueueClear() {
            int count = analyzer.heavyQueue.ProductHeavyQueue.Count;
            var heavyQueue = analyzer.heavyQueue.ProductHeavyQueue;

            for (int i = 0; i<count; i++)
            {
                _robotName = "heavyRobot_" + i;

                new HeavyRobot(_robotName);
             
                Console.WriteLine($"Робот {_robotName} был создан и забрал из очереди товар весом {heavyQueue.Peek().Weight}");
                storage.Add(heavyQueue.Peek());
    
                heavyQueue.Dequeue();               
            }
        }

        public void LigtQueueClear()
        {
            int count = analyzer.lightQueue.ProductLightQueue.Count;
            var lightQueue = analyzer.lightQueue.ProductLightQueue;

            for (int i = 0; i < count; i++)
            {
                _robotName = "lightRobot_" + i;

                new HeavyRobot(_robotName);

                Console.WriteLine($"Робот {_robotName} был создан и забрал из очереди товар весом {lightQueue.Peek().Weight}");
                storage.Add(lightQueue.Peek());
                lightQueue.Dequeue();                
            }
        }
    }
}
