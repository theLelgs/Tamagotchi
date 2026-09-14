Console.WriteLine("Name your first tamagotchi!");
Tamagotchi tamagotchi1 = new()
{
    Name=Console.ReadLine()
};
Console.WriteLine("Name your second tamagotchi!");
Tamagotchi test2 = new()
{
    Name=Console.ReadLine()
};

List<Tamagotchi> tamagotchis = [tamagotchi1, test2];

List<string> commandList = ["feed", "hi", "teach", "create", "murder"];
while (tamagotchis.Count>0)
{
    
    foreach(Tamagotchi tamagotchi in tamagotchis)
    {
        tamagotchi.PrintStats();
        Console.WriteLine();
    }
    Console.WriteLine();
    
    {//What does the player want to do?
        string input = Console.ReadLine().ToLower();
        Console.Clear();
        if (commandList.Contains(input.ToLower()))
        {
            if(input=="feed")//Feed your tamagotchi
            {
                if (tamagotchis.Count>1)
                {
                    
                    Console.WriteLine("Who do you want to feed?");
                    foreach (Tamagotchi tamagotchi in tamagotchis)
                    {
                        Console.WriteLine(tamagotchi.Name);
                    }
                    string text = Console.ReadLine();
                    foreach (Tamagotchi tamagotchi in tamagotchis)
                    {
                        if (text==tamagotchi.Name)
                        {
                            tamagotchi.Feed();
                        }
                    }
                }
                else
                {
                    tamagotchis[0].Feed();
                }
                Console.WriteLine("You fed your tamagotchi!");
            }
            else if(input=="hi")//Tamagotchi says a word
            {
                if (tamagotchis.Count>1)
                {
                Console.WriteLine("Who do you want to say hi to?");
                foreach (Tamagotchi tamagotchi in tamagotchis)
                {
                    Console.WriteLine(tamagotchi.Name);
                }
                string text = Console.ReadLine();
                foreach (Tamagotchi tamagotchi in tamagotchis)
                {
                    if (text==tamagotchi.Name)
                    {
                        tamagotchi.Hi();
                    }
                }
                }
                else
                {
                    tamagotchis[0].Hi();
                }
                Console.WriteLine();
            }
            else if (input=="teach")//Teach a new word to your tamagotchi
            {
                if (tamagotchis.Count>1)
                {
                    Console.WriteLine("Who do you want to teach a word?");
                foreach (Tamagotchi tamagotchi in tamagotchis)
                {
                    Console.WriteLine(tamagotchi.Name);
                }
                string text = Console.ReadLine();
                foreach (Tamagotchi tamagotchi in tamagotchis)
                {
                    if (text==tamagotchi.Name)
                    {
                        Console.WriteLine("What word do you want to teach?");
                        tamagotchi.Teach(Console.ReadLine());
                    }
                }
                }
                else
                {
                    Console.WriteLine("What word do you want to teach?");
                    tamagotchis[0].Teach(Console.ReadLine());
                }
                
                
            }
            else if (input=="create")//Make new tamagotchi
            {
                Console.WriteLine("What do you want to name your new tamagotchi?");
                Tamagotchi tamagotchi = new(){Name=Console.ReadLine()};
                tamagotchis.Add(tamagotchi);
            }
            else if(input=="murder")//Kill a tamagotchi
            {
                Tamagotchi toremove = new();
                if (tamagotchis.Count>1)
                {
                Console.WriteLine("Who do you want to kill?");
                foreach (Tamagotchi tamagotchi in tamagotchis)
                {
                    Console.WriteLine(tamagotchi.Name);
                }
                string text = Console.ReadLine();
                
                foreach (Tamagotchi tamagotchi in tamagotchis)
                {
                    if (text==tamagotchi.Name)
                    {
                        toremove=tamagotchi;
                    }
                }
                }
                else
                {
                    toremove=tamagotchis[0];
                }
                
                tamagotchis.Remove(toremove);
            }
        }
    }
    {//Remove dead tamagotchis
    List<Tamagotchi> toRemove = [];
    foreach (Tamagotchi tamagotchi in tamagotchis)
    {
        tamagotchi.Tick();
        if (!tamagotchi.GetAlive())
        {
            toRemove.Add(tamagotchi);
        }
    }
    foreach(Tamagotchi tamagotchi in toRemove)
    {
        tamagotchis.Remove(tamagotchi);
    }
    toRemove=[];
    }

}
Console.WriteLine("All your tamagotchis died, skill issue");
Console.ReadLine();