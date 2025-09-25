using System.Runtime.CompilerServices;

public class Tamagochi
{
    private int hunger = 0;
    private int boredom = 0;
    private int words = 0;
    public string name = "";

    private bool isalive = true;

    public void Feed()
    {
        hunger -= 2;

        Console.Clear();
    }
    public void Hi()
    {
        Console.WriteLine("write the name");
        while (name == "")
        {
            name = Console.ReadLine();
        }
        Console.Clear();
    }
    public void Teach()
    {
        Console.WriteLine("teach him a word");
        string lol = "";
        while (lol == "")
        {
            lol = Console.ReadLine();
        }
        boredom -= 2;
        words ++;
        Console.Clear();
    }
    public void Tick()
    {
        Console.WriteLine("tick");
        hunger++;
        boredom++;
        if (boredom < 0)
        {
            boredom = 0;
        }
        if (hunger < 0)
        {
            hunger = 0;
        }
    }
    public void Printstats()
    {
        Console.WriteLine($"Name({name})Hunger:{hunger} Boredom:{boredom} Words:{words}");
    }
    public bool GetAlive()
    {
        if (hunger >= 10 || boredom >= 10)
        {
            return false;
        }

        return true;
    }
    private void ReduceBoredom()
    {

    }




}
