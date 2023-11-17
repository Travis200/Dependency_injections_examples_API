namespace dependency_injection_examples
{
    class CafeWorkerPropertyInjection
    {
        public IDrinkMachine DrinkMachine { private get; set; }
        public CafeWorkerPropertyInjection()
        {

        }
        public string ServeDrink(string drink)
        {
            string pouredDrink = DrinkMachine.PourDrink(drink);
            return ($"Your {pouredDrink} has been served.");
        }
    }
}
