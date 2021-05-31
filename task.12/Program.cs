﻿using System;
using task._12.Robots;

namespace task._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            
            var storage = new Storage();
            NewProduct[] p = { 
                new NewProduct(1, 55),
                new NewProduct(1, 55),               
                new NewProduct(2, 3), 
                new NewProduct(3, 3), 
                new NewProduct(4, 85) };

            for (int i = 0;i<p.Length; i++) {
                manager.analyzer.Sorting(p[i]);
            }
            manager.HeavyRobotCreate();
            manager.LigtRobotCreate();

            
            
        }
    }
}