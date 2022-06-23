// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geef een hoek in graden° (enkel het cijfer)");
int input = Convert.ToInt32(Console.ReadLine());
double rad = Math.PI * input / 180;
Console.WriteLine(rad);
Console.WriteLine(Math.Sin(rad));
Console.WriteLine(Math.Cos(rad));
Console.WriteLine(Math.Tan(rad));