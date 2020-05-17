using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
     class USIngredientFactory : IngredientFactory
    {
        public override IBeans GetBeans()
        {
            return new BlackBeans();
        }

        public override ICheese GetCheese()
        {
            return new PepperJackCheese();
        }

        public override IChili GetChili()
        {
            return new HabaneroChilies();
        }

        public override ICreamCheese GetCreamCheese()
        {
            return new ChunkyCreamCheese();
        }

        public override IGuacomole GetGuacomole()
        {
            return new Guacamole();
        }

        public override IMeat GetMeat()
        {
            return new Beef();
        }

        public override IPoultry GetPoultry()
        {
            return new Turkey();
        }

        public override IRice GetRice()
        {
            return new BasmatiRice();
        }

        public override ITomato GetTomato()
        {
            return new Salsa();
        }

        public override IVegetation GetVegetation()
        {
            return new Chickpeas();
        }
    }
}
