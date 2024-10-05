using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Dominos
{
    public class DominosBurger : IBurger
    {
        public void Order()
        {
            Console.WriteLine("Here is your burger from Dominos Kitchen");
        }
    }
}
