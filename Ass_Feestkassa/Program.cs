// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aantal portie(s) Friet?");
int friet = int.Parse(Console.ReadLine());

Console.WriteLine("Aantal Koninginnenhapje(s)?");
int hapje = int.Parse(Console.ReadLine());

Console.WriteLine("Aantal Ijs(jes)?");
int ijs = int.Parse(Console.ReadLine());

Console.WriteLine("Aantal drank comsumptie(s)?");
int drank = int.Parse(Console.ReadLine());

Console.WriteLine($"SubTotalen: Friet {friet*20} / Kngnhap {hapje*10} / Ijs {ijs*3} / Drank {drank*2} \n Het Totaal is:{friet * 20+hapje * 10+ijs * 3+drank * 2} ");