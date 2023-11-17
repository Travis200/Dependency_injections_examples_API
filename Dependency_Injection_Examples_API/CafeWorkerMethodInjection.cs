namespace dependency_injection_examples
{
    class CafeWorkerMethodInjection
    {
        public CafeWorkerMethodInjection()
        {

        }

        public string ServeDrink(IDrinkMachine drinkMachine, string drink)
        {
            string pouredDrink = drinkMachine.PourDrink(drink);
            return ($"Your {pouredDrink} has been served.");
        }
    }
}
