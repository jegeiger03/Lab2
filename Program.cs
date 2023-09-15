// See https://aka.ms/new-console-template for more information
int numberOfPies;
int amountofToppings;
double serviceFee;
double Drivers_Wage = 5.27;
int cost_of_pie = 10;
double cost_of_topping = 0.25;
double order_cost = 0;

Console.WriteLine("How many pies?");
Console.ReadLine(numberOfPies);

Console.WriteLine("How many toppings?");
Console.ReadLine(amountofToppings);

Console.Writeline("How much will you tip?");
Console.ReadLine(serviceFee);

order_cost = Drivers_Wage + serviceFee + (cost_of_pie * numberOfPies) + (cost_of_topping * amountofToppings)
Console.WriteLine(order_cost);
