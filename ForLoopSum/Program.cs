int sum = 0;

for(int i =1;i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Total:{sum}");
sum = sum + i;
}
Console.WriteLine($"total {sum}");
