using AbstractFactoryDesignPattern.Chicken_Republic;

namespace AbstractFactoryDesignPattern
{
    public class ChickenRepublic : FoodFactory
    {
        public override IBurger CreateBurger()
        {
            return new ChickenRepublicBurger();
        }

        public override IFriedRice CreateFriedRice()
        {
            return new ChickenRepublicFriedRice();
        }
    }
}
