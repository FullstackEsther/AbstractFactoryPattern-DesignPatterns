using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class ChickenRepublicBurger : IBurger
    {
        public void Order()
        {
            Console.WriteLine("Here is your burger from Chicken Republic");
        }
    }
}
