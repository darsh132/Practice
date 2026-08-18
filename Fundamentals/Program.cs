// 12. Write a method that checks whether a number is prime.

static bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPrime(number))
    Console.WriteLine($"{number} is a prime number.");
else
    Console.WriteLine($"{number} is not a prime number.");