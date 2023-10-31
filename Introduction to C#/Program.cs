int counter = 0;

for(int i = 1; i < 20; i++)
{
    if (i % 3 == 0)
    {

        counter = counter + i;
    }
}

Console.WriteLine($"The sum of all integers 1 through 20 is: {counter}");