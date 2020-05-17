using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    class ingredientDecorator:Ingredient
    {
        private Ingredient ingredient;
        public ingredientDecorator(Ingredient ing)
        {
            ingredient = ing;
        }

        public override void GetDiscription()
        {
            ingredient.GetDiscription();
        }

        public override void Cost()
        {
            ingredient.Cost();
        }
    }
}
