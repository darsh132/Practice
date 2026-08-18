// 5. Write a program that checks whether a number is positive, negative, or zero.

Console.Write("Enter first integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > 0) 
    Console.WriteLine("Number is positive !");
else if(firstNumber < 0)
    Console.WriteLine("Number is negative !");
else
    Console.WriteLine("Number is zero !");