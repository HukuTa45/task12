using System;
using System.Collections.Generic;
using System.Text;
using task._12.Robots;

namespace task._12.ProductStorage
{
    public class HeavyQueue
    {
        public Queue<NewProduct> ProductHeavyQueue = new Queue<NewProduct>();

        public void AddQueueHeavy(NewProduct product)
        {
            if (product != null)
                ProductHeavyQueue.Enqueue(product);
        }
    }
}
