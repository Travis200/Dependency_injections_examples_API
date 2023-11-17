namespace dependency_injection_examples
{
    class CafeWorkerCtorInjection
    {
        readonly IDrinkMachine _drinkMachine;
        public CafeWorkerCtorInjection(IDrinkMachine drinkMachine)
        {
            this._drinkMachine = drinkMachine;
        }

        public string ServeDrink(string drink)
        {
            string pouredDrink = this._drinkMachine.PourDrink(drink);
            return ($"Your {pouredDrink} has been served.");
        }
    }
}
