
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int showSecondValue(int number)
{
    int number3 = number % 10;
    int number1 = number % 100;
    int secondValue = number1 / 10;

    return secondValue;
}

int secondValue = showSecondValue(number);
Console.WriteLine(secondValue);

showSecondValue(number);