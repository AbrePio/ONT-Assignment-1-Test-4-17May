using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
     class SAIngredientFactory : IngredientFactory
    {
        public override IBeans GetBeans()
        {
            return new RefriedBeans();
        }

        public override ICheese GetCheese()
        {
            return new CheddarCheese();
        }

        public override IChili GetChili()
        {
            return new JalapenoChilies();
        }

        public override ICreamCheese GetCreamCheese()
        {
            return new SmoothCreamCheese();
        }

        public override IGuacomole GetGuacomole()
        {
            return new SlicedAvocados();
        }

        public override IMeat GetMeat()
        {
            return new Mutton();
        }

        public override IPoultry GetPoultry()
        {
            return new Chicken();
        }

        public override IRice GetRice()
        {
            return new JasminRice();
        }

        public override ITomato GetTomato()
        {
            return new Relish();
        }

        public override IVegetation GetVegetation()
        {
            return new Samp();
        }
    }
}
