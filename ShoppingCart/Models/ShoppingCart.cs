
using System.Collections.Generic;

namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        public void AddProduct(string name, double price)
        {
           Product product = new Product(name, price);
            _products.Add(product);
        }

        public List<Product> GetProducts()
        {

            return _products; 
        }

        public double GetTotalPrice()
        {
            double osszeg = 0;
            for (int i = 0; i < _products.Count; i++)
            {
                osszeg += _products[i].Price;
            }
            return osszeg;
        }

        public void RemoveProduct(string name)
        {
            bool vanbenne = false;

            foreach (var item in _products)
            {
                if(item.Name == name)
                {
                    vanbenne= true;
                }
                else
                {
                   continue;
                }
            }

            if (vanbenne == false)
            {
                throw new InvalidOperationException("Nincs benne a kosarba");
            }


            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Name == name)
                {
                    _products.RemoveAt(i);
                }

            }
            
        }
    }

         

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!

    }

