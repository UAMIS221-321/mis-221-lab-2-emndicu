const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0.00;


Console.WriteLine("Enter the number of Sandwiches: ");
numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter the number of toppings:  ");
numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter tip: ");
tip = double.Parse(Console.ReadLine());

double totalSandwichCost = 0;
totalSandwichCost = COST_OF_SANDWICH*numberOfSandwiches;

double totalToppingCost = 0;
totalToppingCost = COST_OF_TOPPING*numberOfToppings;

double baseCost = 0.0;
baseCost = totalSandwichCost + totalToppingCost;

double orderCost = 0;
orderCost = tip + baseCost*(1-DISCOUNT_AMOUNT);

System.Console.WriteLine("Your total is: " + orderCost);
