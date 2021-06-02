using System;
using System.Collections.Generic;
using System.Text;
using task._12.Robots;

namespace task._12
{
    public class Storage
    {       
        private Dictionary<int, double> _products = new Dictionary<int, double>();

        public IReadOnlyDictionary<int, double> Products => _products;

        public void Add(Product newProduct) {
            _products.Add(newProduct.Id, newProduct.Weight);
        }

        public void GetProduct(int id)
        {
            _products.Remove(id);
        }

    }
}
