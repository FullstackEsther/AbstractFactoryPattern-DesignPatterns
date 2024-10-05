using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Dominos
{
    public class DominosFriedRice : IFriedRice
    {
        public void Order()
        {
            Console.WriteLine("Here is your fried rice from Dominos Kitchen");
        }
    }
}
