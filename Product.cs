﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2_Exrcise_1
{
    class Product
    {
        public string Name;
        public string Description;
        public double Price;
        public int[] Rate;
        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nDescription: {Description}");
        }
    }
}
