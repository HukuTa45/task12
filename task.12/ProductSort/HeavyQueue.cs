using System;
using System.Collections.Generic;
using System.Text;
using task._12.Robots;

namespace task._12.ProductStorage
{
    public class HeavyQueue
    {
        public Queue<Product> ProductHeavyQueue = new Queue<Product>();

        public void AddQueueHeavy(Product product)
        {
            if (product != null)
                ProductHeavyQueue.Enqueue(product);
        }
    }
}
