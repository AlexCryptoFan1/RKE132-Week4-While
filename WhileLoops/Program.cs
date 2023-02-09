
Random rnd=new Random();
int cpuRandom;
bool LoopActive = true;
while (LoopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine(cpuRandom);
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("yes");
        break;
    }    
    else
    {
        Console.WriteLine("no");
    }    

}    