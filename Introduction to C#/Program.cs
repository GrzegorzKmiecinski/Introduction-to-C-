var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] +
        fibonacciNumbers[fibonacciNumbers.Count - 2]);
}

for (int i = 0; i < fibonacciNumbers.Count; i++)
{
    Console.WriteLine(fibonacciNumbers[i]);
}