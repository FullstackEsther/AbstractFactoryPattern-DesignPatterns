﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class FoodFactory
    {
        public abstract IBurger CreateBurger();
        public abstract IFriedRice CreateFriedRice(); 
    }
}
