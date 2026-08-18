// 3. Write a method that swaps two integers without using a temporary variable.

Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

firstNumber = firstNumber + secondNumber;
secondNumber =  firstNumber - secondNumber;
firstNumber = firstNumber - secondNumber;

Console.WriteLine($"Swapped numbers are : {firstNumber}, {secondNumber}");
