using System;
using System.Collections.Generic;

namespace Coffee
{
    
    class Drink
    {
        private int _price;
        private string _name;
        private Dictionary<string, int> _recipe;
        public bool inStock;
    }


    class CoffeeMaker
    {
        private int _sugar;
        private int _water;
        private int _milk;
        private int _glasses;
        private Dictionary<string, int> _powders;
        private bool _adminMode;
        private int _moneyHeld;
        private List<Drink> _drinks; // Реализовать добавление.
        
        public CoffeeMaker()
        {
            _powders = new Dictionary<string, int>
            {
                { "Espresso", 30 }, // Одна порция порошка на напиток.
                { "Doppio", 30 },
                { "Tripplo", 30 },
                { "Ritretto", 30 },
                { "Lungo", 30 },
                { "Americano", 30 },
                { "Cappuccino", 30 },
                { "Latte", 30 },
                { "Romano", 30 },
                { "Irish", 30 }
            };
            _water = 40000; // В мл.
            _milk = 2000; // В мл.
            _glasses = 200;
            _adminMode = false;
            _moneyHeld = 100; // В рублях.
        }

        public void MakeDrink(string drinkName) // Новые порошки мы создавать не умеем, поэтому работаем только с существующими.
        {
            if(IsInStock(drinkName))
            {

            }
            else
            {
                Console.WriteLine("К сожалению, данный напиток отсутствует.");
            }
        }
        public bool IsInStock(string drinkName)
        {
            if(_powders[drinkName]>0) // Доделать.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateNewDrink(string powder, string water, string milk, string price, string name)
        {
            if(_adminMode)
            {
                


            }
            else
            {
                Console.WriteLine("Не хватает прав доступа.");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 10; j++)
            {
                int i;
                List.Add(i);
            }
        }
    }
}
