using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    interface IPoultry  //----- for abstract and factory
    //interface IPoultry : ingredientDecorator  //------ for decorator pattern
    {
        // --------------------abstract and factory
        string Poultry { get; }
        int Price { get; }
        // -----------------------end of abstract and factory

        // -------------Decorator start
        //Ingredient ingredient;
        //public override IPoultry(Ingredient ingredient) : base(ingredient)
        //{
        //    this.ingredient = ingredient;
        //}


        //-----------------------end of decorator
    }
}
