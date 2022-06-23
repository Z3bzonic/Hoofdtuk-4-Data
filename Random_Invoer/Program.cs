// See https://aka.ms/new-console-template for more information
Random rLengte = new Random();
Random rGewicht = new Random();
double gewicht =Math.Round(40 + rGewicht.NextDouble() * 400, 2);
double lengte = Math.Round(1.4 + rLengte.NextDouble() * 2.2, 2);
// min max bepaling op een random double wel even moeten opzoeken, daar zei men om de min nog van de max af te trekken maar dat lijkt me overbodig?
Console.WriteLine($"Je gewicht is {gewicht} Kg");
Console.WriteLine($"Je lengte is {lengte} M");
float bmi = (float)Math.Round((gewicht / (lengte * 2)),2);
Console.WriteLine(bmi);
