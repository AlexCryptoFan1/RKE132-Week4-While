Random rnd = new Random();

int Sum = 0;
for (int i = 0; i < 3; i++)
{
    int myRandomNum = rnd.Next(0, 11); // 0-10
    Console.WriteLine(myRandomNum);
    Sum = Sum + myRandomNum;
    Console.WriteLine(Sum);
}
