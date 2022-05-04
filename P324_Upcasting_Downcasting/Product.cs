using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    class Product
    {
        string _name;
        public double Price;
        public int Count;
        public double TotalInCome;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Zehmet olmasa productin adini qeyd edin");
                }
                else
                {
                    _name = value;
                }
            }
        }

      

        public int Sell()
        {
            if (Count > 0 && !string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name))
            {
                Count--;
                TotalInCome += Price;
                return Count;
            }
            else
            {
                Console.WriteLine("Stock-da yoxdur");
                return Count;
            }
        }
    }
}
