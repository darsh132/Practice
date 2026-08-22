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

# 13. Write a program that prints all prime numbers in a given range
```csharp
Console.Write("Enter starting number: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter ending number: ");
int end = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Prime numbers between {start} and {end}:");

for (int number = start; number <= end; number++)
{
    if (number < 2)
        continue;

    bool isPrime = true;

    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(number);
    }
}
```

# 14. Write a method that counts the digits in an integer without converting it to a string.

```csharp
static int CountDigits(int number)
{
    if (number == 0)
        return 1;

    int count = 0;

    number = Math.Abs(number);

    while (number > 0)
    {
        number = number / 10;
        count++;
    }

    return count;
}

Console.Write("Enter an integer: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(number);

Console.WriteLine($"Number of digits: {result}");
```

# 15. Write a method that reverses an integer while preserving its sign.

```csharp
static int ReverseNumber(int number)
{
    int sign = number < 0 ? -1 : 1;

    number = Math.Abs(number);

    int reverse = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reverse = reverse * 10 + digit;
        number = number / 10;
    }

    return reverse * sign;
}

Console.Write("Enter an integer: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ReverseNumber(number);

Console.WriteLine($"Reversed number: {result}");
```
# 16. Write a method that checks whether an integer is a palindrome.
```csharp
int number = 1221;
Console.WriteLine($"{number} is palindrome: {IsPalindrome(number)}");

static bool IsPalindrome(int number)
{
    // Negative numbers are not palindrome (e.g., -121 != 121-)
    if(number < 0)
        return false;

    int original = number;
    int reversed = 0;

    while(number > 0)
    {
        int remainder = number % 10;
        reversed = (reversed * 10) + remainder;
        number /= 10;
    }

    return original == reversed;
}
```
# 17. Write a method that calculates the sum of digits of an integer.
```csharp
int number =  12345;
Console.WriteLine($"Sum of digits of {number} is: {SumOfDigits(number)}");

static int SumOfDigits(int number)
{
    // Handle negative numbers by converting to positive
    number = Math.Abs(number);

    int sum = 0;

    while(number > 0)
    {
        sum += number % 10; // Extract and add the last digit
        number /= 10; // Remove the last digit 
    }

    return sum;
}
```

# 18. Write a method that calculates the product of digits of an integer.

```csharp
int number = 1234;
Console.WriteLine($"Product of digits of {number} is: {ProductOfDigits(number)}");

static int ProductOfDigits(int number)
{
    // If the number is 0, the product of its digits is 0
    if(number == 0)
        return 0;

    // Convert negative numbers to positive
    number = Math.Abs(number);

    int product = 1;

    while(number > 0)
    {
        int digit = number % 10; // Extract the last digit
        product *= digit; // Multiply to the running product
        number /= 10;
    }

    return product;
}
```

# 19. Write a method that calculates the GCD of two integers.

```csharp
int a = 48;
int b = 18;
Console.WriteLine($"GCD of {a} and {b} is: {CalculateGCD(a, b)}");

static int CalculateGCD(int a, int b)
{
    // Use positive values
    a = Math.Abs(a);
    b = Math.Abs(b);

    // Euclidean algorithm
    while(b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}
```

# 20. Write a method that calculates the LCM of two integers.
```csharp
int a = 12;
int b = 18;
Console.WriteLine($"LCM of {a} and {b} is: {CalculateLCM(a, b)}");

static int CalculateLCM(int a, int b)
{
    // LCM of 0 with any number is 0
    if(a == 0 || b == 0)
        return 0;

    a = Math.Abs(a);
    b = Math.Abs(b);

    // Formula: LCM(a, b) = (|a * b|) / GCD(a, b)
    // Divide first to prevent integer overflow
    return (a / CalculateGCD(a, b)) * b;
}

static int CalculateGCD(int a, int b)
{
    while(b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}
```

# 21. Write a program that prints all Armstrong numbers in a given range.
```csharp
int start = 1;
int end = 1000;

Console.WriteLine($"Armstrong numbers between {start} and {end}");

for(int i = start; i <= end; i++)
{
    if(IsArmstrong(i))
    {
        Console.Write($"{i} ");
    }
}

static bool IsArmstrong(int number)
{
    if(number < 0)
        return false;

    // Count the number of digits
    int digits = number == 0 ? 1 : (int)Math.Floor(Math.Log10(number)) + 1;

    int temp = number;
    int sum = 0;

    while(temp > 0)
    {
        int digit = temp % 10;
        sum += (int)Math.Pow(digit, digits);
        temp /= 10;
    }

    return sum == number;
}
```

# 22. Write a method that checks whether a number is an Armstrong number.
```csharp
int number = 153;
Console.WriteLine($"{number} is an Armstrong number: {IsArmstrong(number)}");

static bool IsArmstrong(int number)
{
    // Negative numbers cannot be Armstrong numbers
    if(number < 0)
        return false;
    
    // Determine the number of digits
    int digits = number == 0 ? 1 : (int)Math.Floor(Math.Log10(number)) + 1;

    int temp = number;
    int sum = 0;

    while(temp > 0)
    {
        int digit = temp % 10;
        sum += (int)Math.Pow(digit, digits);
        temp /= 10;
    }

    return sum == number;
}
```
