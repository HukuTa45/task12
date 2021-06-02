using System;
using System.Collections.Generic;
using System.Text;
using task._12.Robots;

namespace task._12.ProductStorage
{
    public class LightQueue
    {
        public Queue<NewProduct> ProductLightQueue = new Queue<NewProduct>();

        public void AddQueueLight(NewProduct product)
        {
            if(product!=null)
            ProductLightQueue.Enqueue(product);
           
        }
    }
}
