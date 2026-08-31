Tamagotchi test = new()
{
    Name="Your Best Friend"
};

List<string> commandList = ["feed", "hi", "teach"];
while (test.IsAlive())
{
    test.Tick();
    string input = Console.ReadLine();
    Console.Clear();
    if (commandList.Contains(input.ToLower()))
    {
        if(input.ToLower()=="feed")
        {
            Console.WriteLine("You fed your tamagotchi!");
            test.Feed();
        }
        else if(input.ToLower()=="hi")
        {
            test.Hi();
        }
        else if (input.ToLower()=="teach")
        {
            Console.WriteLine("What word do you want to teach?");
            test.Teach(Console.ReadLine());
        }
    }
    
    test.PrintStats();
    
}
Console.ReadLine();