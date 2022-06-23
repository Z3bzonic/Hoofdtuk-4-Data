// See https://aka.ms/new-console-template for more information
// Ik hou niet van Jinx stuff op doodgaan :p dus deze is met geld!
string lijn1 = @" $$$$$$\                     $$\                 $$\                                           $$$$$$$\            $$\           $$\       $$\ ";
string lijn2= @"$$  __$$\                    $$ |                $$ |                                          $$  __$$\           $$ |          $$ |      \__|
";
string lijn3 = @"$$ /  $$ | $$$$$$\  $$$$$$\  $$ |  $$\  $$$$$$\  $$ |      $$\    $$\ $$$$$$\  $$$$$$$\        $$ |  $$ | $$$$$$\  $$ | $$$$$$\  $$$$$$$\  $$\ 
";
string lijn4 = @"$$ |  $$ |$$  __$$\ \____$$\ $$ | $$  |$$  __$$\ $$ |      \$$\  $$  |\____$$\ $$  __$$\       $$ |  $$ |$$  __$$\ $$ |$$  __$$\ $$  __$$\ $$ |
";
string lijn5 = @"$$ |  $$ |$$ |  \__|$$$$$$$ |$$$$$$  / $$$$$$$$ |$$ |       \$$\$$  / $$$$$$$ |$$ |  $$ |      $$ |  $$ |$$$$$$$$ |$$ |$$ /  $$ |$$ |  $$ |$$ |
";
string lijn6 = @"$$ |  $$ |$$ |     $$  __$$ |$$  _$$<  $$   ____|$$ |        \$$$  / $$  __$$ |$$ |  $$ |      $$ |  $$ |$$   ____|$$ |$$ |  $$ |$$ |  $$ |$$ |
";
string lijn7 = @" $$$$$$  |$$ |     \$$$$$$$ |$$ | \$$\ \$$$$$$$\ $$ |         \$  /  \$$$$$$$ |$$ |  $$ |      $$$$$$$  |\$$$$$$$\ $$ |$$$$$$$  |$$ |  $$ |$$ |
";
string lijn8 = @" \______/ \__|      \_______|\__|  \__| \_______|\__|          \_/    \_______|\__|  \__|      \_______/  \_______|\__|$$  ____/ \__|  \__|\__|
";
string lijn9 = @"                                                                                                                       $$ |                    
";
string lijn10 = @"                                                                                                                       $$ |                    
";
string lijn11 = @"                                                                                                                       \__|                    ";


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(lijn1);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(lijn2);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(lijn3);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(lijn4);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(lijn5);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(lijn6);

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(lijn7);

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(lijn8);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(lijn9);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(lijn10);

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(lijn11);  


Random random = new Random();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Hoeveel geld ga ik zomaar ontvangen?");

decimal brrrrrr = (decimal)random.NextDouble()*1000;
Console.WriteLine($"{Math.Round(brrrrrr)}");


while (true)
{
    Console.WriteLine("Druk enter om verder te raden, \"n\" om af te sluiten");
    var input = Console.ReadLine();
    Console.WriteLine("Hoeveel geld ga ik zomaar ontvangen?");
    if (input == "n")
    {
        break;
    }
    brrrrrr = (decimal)random.NextDouble() * 1000;
    Console.WriteLine($"{Math.Round(brrrrrr)}");
}

// ik heb gekozen voor decimalen voor geld maar voor de gebruiker een afgeronde weergave
// Wel een verwarring stukje, ik kan niet vinden waar het aantal decimalen bepaald wordt :D2 bv 
