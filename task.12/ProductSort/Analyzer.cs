using System;
using System.Collections.Generic;
using System.Text;
using task._12.ProductStorage;
using task._12.Robots;

namespace task._12.ProductSort
{
     public class Analyzer
    {      
        public HeavyQueue heavyQueue = new HeavyQueue();
        public LightQueue lightQueue = new LightQueue();

        public void Sorting(Product product)
        {

            if (product.Weight > 50)
                heavyQueue.AddQueueHeavy(product);
            else
                lightQueue.AddQueueLight(product);
        }
    }
}
