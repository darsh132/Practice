// 22. Write a method that checks whether a number is an Armstrong number.

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