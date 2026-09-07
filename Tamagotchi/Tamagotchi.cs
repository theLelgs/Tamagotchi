public class Tamagotchi
{
    public string Name;
    private int hunger=0;
    private int boredom=0;
    private List<string> words=["Hi"];
    private bool isAlive=true;
    public void Feed()
    {
        hunger=0;
    }
    public void Hi()
    {
        Console.WriteLine(Name + ": " + words[Random.Shared.Next(words.Count)]);
        ReduceBoredom();
    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        hunger+=1;
        boredom+=1;
        if (hunger>=10||boredom>=10)
        {
            isAlive=false;
        }
    }
    public void PrintStats()
    {
        Console.WriteLine($"{Name}'s Stats: \nHunger: {hunger}\nBoredom: {boredom}\n");
        if (isAlive)
        {
            Console.WriteLine($"{Name} is alive!");
        }
        else
        {
            Console.WriteLine($"{Name} died lol");
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        boredom=0;
    }
}