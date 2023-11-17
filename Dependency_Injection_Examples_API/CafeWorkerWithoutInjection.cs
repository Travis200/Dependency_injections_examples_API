namespace dependency_injection_examples
{
    class CafeWorkerWithoutInjection
    {
        readonly CoffeeMachine _coffeeMachine;
        public CafeWorkerWithoutInjection()
        {
            this._coffeeMachine = new CoffeeMachine();
        }

        public string ServeDrink(string drink)
        {
            string pouredDrink = this._coffeeMachine.PourDrink(drink);
            return ($"Your {pouredDrink} has been served.");
        }
    }
}
