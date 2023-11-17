var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/coffee/constructor_injection", (string drinkFlavour) => "") {

}

app.MapGet("/coffee/method_injection", (string drinkFlavour) => "") {

}

app.MapGet("/coffee/property_injection", (string drinkFlavour) => "") {

}

app.MapGet("/milkshake/constructor_injection", (string drinkFlavour) => "") {

}

app.MapGet("/milkshake/method_injection", (string drinkFlavour) => "") {

}

app.MapGet("/milkshake/property_injection", (string drinkFlavour) => "") {

}

app.Run();
