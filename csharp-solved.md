# 1. Write a program that reads two integers and prints their sum, difference, product, quotient, and remainder.
```csharp
Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = firstNumber + secondNumber;
int difference = firstNumber - secondNumber;
int product = firstNumber * secondNumber;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");

if (secondNumber != 0)
{
    int quotient = firstNumber / secondNumber;
    int remainder = firstNumber % secondNumber;

    Console.WriteLine($"Quotient: {quotient}");
    Console.WriteLine($"Remainder: {remainder}");
}
else
{
    Console.WriteLine("Quotient: Cannot divide by zero");
    Console.WriteLine("Remainder: Cannot divide by zero");
}
```
# 2. Write a method that swaps two integers using a temporary variable.

```csharp
Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int temp = 0;
temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine($"Swapped numbers are : {firstNumber}, {secondNumber}");
```
# 3. Write a method that swaps two integers without using a temporary variable.

```csharp
Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

firstNumber = firstNumber + secondNumber;
secondNumber =  firstNumber - secondNumber;
firstNumber = firstNumber - secondNumber;

Console.WriteLine($"Swapped numbers are : {firstNumber}, {secondNumber}");
```

# 4. Write a program that determines whether an integer is even or odd.

```csharp
Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber % 2 == 0) 
    Console.WriteLine("Integer is even !");
else
    Console.WriteLine("Integer is odd !");
```
# 5. Write a program that checks whether a number is positive, negative, or zero.

```csharp

Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > 0) 
    Console.WriteLine("Number is positive !");
else if(firstNumber < 0)
    Console.WriteLine("Number is negative !");
else
    Console.WriteLine("Number is zero !");
```

# 6. Write a method that returns the maximum of two integers without using Math.Max.

```csharp
Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber) 
    Console.WriteLine($"{firstNumber} is maximum");
else
    Console.WriteLine($"{secondNumber} is maximum");
```
# 7. Write a method that returns the maximum of three integers using conditional operators.

```csharp
static int MaxOfThree(int a, int b, int c)
{
    return (a > b)
        ? (a > c ? a : c)
        : (b > c ? b : c);
}

Console.WriteLine(MaxOfThree(10, 25, 15)); 
```
# 8. Write a method that calculates factorial iteratively.

```csharp
static long Factorial(int number)
{
    long result = 1;

    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
```

# 9. Write a method that calculates factorial recursively.
```csharp
static long Factorial(int number)
{
    if (number == 0 || number == 1)
        return 1;

    return number * Factorial(number - 1);
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
```

# 10. Write a method that calculates the nth Fibonacci number iteratively.

```csharp
static int Fibonacci(int n)
{
    if (n == 0)
        return 0;

    if (n == 1)
        return 1;

    int previous = 0;
    int current = 1;

    for (int i = 2; i <= n; i++)
    {
        int next = previous + current;
        previous = current;
        current = next;
    }

    return current;
}

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The {n}th Fibonacci number is {Fibonacci(n)}");
```

# 11. Write a method that generates the first N Fibonacci numbers.

```csharp
static void GenerateFibonacci(int n)
{
    int previous = 0;
    int current = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write(previous + " ");

        int next = previous + current;
        previous = current;
        current = next;
    }
}

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

GenerateFibonacci(n);
```