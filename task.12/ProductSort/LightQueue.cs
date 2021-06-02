using System;
using System.Collections.Generic;
using System.Text;
using task._12.Robots;

namespace task._12.ProductStorage
{
    public class LightQueue
    {
        public Queue<Product> ProductLightQueue = new Queue<Product>();

        public void AddQueueLight(Product product)
        {
            if(product!=null)
            ProductLightQueue.Enqueue(product);
           
        }
    }
}
