using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Chicken_Republic
{
    public class ChickenRepublicFriedRice : IFriedRice
    {
        public void Order()
        {
            Console.WriteLine("Here is your fried rice from Chicken Republic");
        }
    }
}
