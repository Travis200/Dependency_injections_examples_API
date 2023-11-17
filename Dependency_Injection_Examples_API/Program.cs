using dependency_injection_examples;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

CoffeeMachine coffeeMachine = new CoffeeMachine();
MilkshakeMachine milkshakeMachine = new MilkshakeMachine();

app.MapGet("/", () => "Hello and welcome to the dependency injection cafe! We serve all " +
"sorts of coffees and milkshakes can make each one in three different ways (constructor injection, " +
"method Injection and property injection). Each of the drink is injected by 'hand'. The dependency " +
"injection container is not used in these examples so we can focus and understand the fundamentals of " +
"dependency injection first. \n\n" +
"All of the drinks can be ordered using get requests.\n" +
"To get a response first specify route as: '{localhost base URL}/{drink type}/{dependency injection type}?drinkFlavour={drink flavour}'. \n" +
"The available drink trypes are: 'coffee' and 'milkshake'. \n" +
"The available injection types are: 'method_injection', 'property_injection' and 'constructor_injection'. \n" +
"For example: If you wanted to get a latte using constructor injection you would use the route '{localhost base URL}/coffee/constructor_injection?drinkFlavour=latte'.");

app.MapGet("/coffee/constructor_injection", (string drinkFlavour) => {
    CafeWorkerCtorInjection barista = new CafeWorkerCtorInjection(coffeeMachine);
    string coffee = barista.ServeDrink(drinkFlavour);
    return coffee;
});

app.MapGet("/coffee/method_injection", (string drinkFlavour) => {
    CafeWorkerMethodInjection barista = new CafeWorkerMethodInjection();
    string coffee = barista.ServeDrink(coffeeMachine, drinkFlavour);
    return coffee;
});

app.MapGet("/coffee/property_injection", (string drinkFlavour) => {
    CafeWorkerPropertyInjection barista = new CafeWorkerPropertyInjection();
    barista.DrinkMachine = coffeeMachine;
    string coffee = barista.ServeDrink(drinkFlavour);
    return coffee;
});

app.MapGet("/milkshake/constructor_injection", (string drinkFlavour) => {
    CafeWorkerCtorInjection milkshakeMachineOperator = new CafeWorkerCtorInjection(milkshakeMachine);
    string milkshake = milkshakeMachineOperator.ServeDrink(drinkFlavour);
    return milkshake;
});

app.MapGet("/milkshake/method_injection", (string drinkFlavour) => {
    CafeWorkerMethodInjection milkshakeMachineOperator = new CafeWorkerMethodInjection();
    string milkshake = milkshakeMachineOperator.ServeDrink(milkshakeMachine, drinkFlavour);
    return milkshake;
});

app.MapGet("/milkshake/property_injection", (string drinkFlavour) => {
    CafeWorkerPropertyInjection milkshakeMachineOperator = new CafeWorkerPropertyInjection();
    milkshakeMachineOperator.DrinkMachine = milkshakeMachine;
    string milkshake = milkshakeMachineOperator.ServeDrink(drinkFlavour);
    return milkshake;
});

app.Run();
