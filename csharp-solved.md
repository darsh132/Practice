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
