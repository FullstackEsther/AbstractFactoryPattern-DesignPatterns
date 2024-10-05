using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Dominos
{
    public class DominosKitchen : FoodFactory
    {
        public override IBurger CreateBurger()
        {
            return new DominosBurger();
        }

        public override IFriedRice CreateFriedRice()
        {
            return new DominosFriedRice();
        }
    }
}
