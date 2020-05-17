using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    class Taco 
    {
        private IPoultry _poultry;
        private IMeat _meat;
        private IVegetation _vegetation;
        private ICheese _cheese;
        private IGuacomole _guacomole;
        private IRice _rice;
        private IBeans _beans;
        private ICreamCheese _creamCheese;
        private ITomato _tomato;
        private IChili _chili;

        public Taco(IngredientFactory ingredientFactory)
        {
            _poultry = ingredientFactory.GetPoultry();
            _meat = ingredientFactory.GetMeat();
            _vegetation = ingredientFactory.GetVegetation();
            _cheese = ingredientFactory.GetCheese();
            _guacomole = ingredientFactory.GetGuacomole();
            _rice = ingredientFactory.GetRice();
            _beans = ingredientFactory.GetBeans();
            _creamCheese = ingredientFactory.GetCreamCheese();
            _tomato = ingredientFactory.GetTomato();
            _chili = ingredientFactory.GetChili();
        }

        public string DescribeTaco()
        {
            return $"Ingredients Available: \n\n" + 
                $"{_poultry.Poultry}\t\t\t R{_poultry.Price}\n" +
                $"{_meat.Meat}\t\t\t R{_meat.Price}\n" +
                $"{_vegetation.Vegetation}\t\t\t R{_vegetation.Price}\n" +
                $"{_cheese.Cheese}\t\t R{_cheese.Price}\n" +
                $"{_guacomole.Guacomole}\t\t R{_guacomole.Price}\n" +
                $"{_rice.Rice}\t\t R{_rice.Price}\n" +
                $"{_beans.Beans}\t\t R{_beans.Price}\n" +
                $"{_creamCheese.CreamCheese}\t R{_creamCheese.Price}\n" +
                $"{_tomato.Tomato}\t\t\t R{_tomato.Price}\n" +
                $"{_chili.Chili}\t R{_chili.Price}\n" ;
        }
    }
}
