// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
float[] poef = new float[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Geef bedrag {i + 1} in");
    //      poef[i] = (float)Convert.ToDouble( Console.ReadLine());
    poef[i] = float.Parse(Console.ReadLine());
}

float som = 0.0F;
for (int i = 0; i < 5; i++)
{
    som = som + poef[i];
}

Console.WriteLine($"de totale poef is € {som}");
Console.Write("Het duurt ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{Math.Ceiling(som / 10)}");
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" weken aan € 10 per week om dit af te betalen");