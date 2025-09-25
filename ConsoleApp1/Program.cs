Tamagochi lol = new();
lol.Hi();

Console.Clear();

while (lol.GetAlive() == true)
{
    lol.Printstats();
    Console.WriteLine("välj 1 eller 2");
    Console.WriteLine("1 ge mat");
    Console.WriteLine("2 lär ord");
    string val = Console.ReadLine();
    if (val == "1")
    {
        lol.Feed();
    }
    if (val == "2")
    {
        lol.Teach();

    }


    lol.Tick();
    Console.Clear();
}


Console.ReadLine();