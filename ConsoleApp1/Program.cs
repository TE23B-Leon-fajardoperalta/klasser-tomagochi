Tamagochi lol = new();
lol.Hi();


while (lol.GetAlive() == true)
{
     lol.Printstats();
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