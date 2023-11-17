namespace dependency_injection_examples
{
    class MilkshakeMachine : IDrinkMachine
    {
        public string PourDrink(string drink)
        {
            string milkshake = $"cold {drink} milkshake";
            return milkshake;
        }
    }
}
