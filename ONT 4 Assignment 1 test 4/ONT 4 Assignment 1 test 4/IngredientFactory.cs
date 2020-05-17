using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    abstract class IngredientFactory
    {
        public abstract IPoultry GetPoultry();
        public abstract IMeat GetMeat();
        public abstract IVegetation GetVegetation();
        public abstract ICheese GetCheese();
        public abstract IGuacomole GetGuacomole();
        public abstract IRice GetRice();
        public abstract IBeans GetBeans();
        public abstract ICreamCheese GetCreamCheese();
        public abstract ITomato GetTomato();
        public abstract IChili GetChili();

    }
}
