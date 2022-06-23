// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geef lengte in m");
float lengte = float.Parse(Console.ReadLine());
Console.WriteLine("Geef gewicht in kg");
float gewicht = (float)Convert.ToDouble(Console.ReadLine());
lengte = lengte * 2;
float bmi = (float)Math.Round((gewicht / lengte), 2);
Console.WriteLine(bmi);