Tamagochi lol = new();
lol.Hi();

Console.Clear();

while (lol.GetAlive() == true)
{
     lol.Printstats();
    Console.WriteLine("välj 1 eller 2");
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
}


Console.ReadLine();