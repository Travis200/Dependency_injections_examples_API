namespace dependency_injection_examples
{
    class CoffeeMachine : IDrinkMachine
    {
        public string PourDrink(string drink)
        {
            string hotDrink = $"hot {drink} coffee";
            return hotDrink;
        }
    }
}
