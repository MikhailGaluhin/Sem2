
//Огромная проблема с пониманием, как совмещать классы. Не понимаю как 
//как вывести этот null, что б он не конфликтовал с int

Console.WriteLine("Введите число");
var? number = Convert.ToInt32(Console.ReadLine());

var showThirdValue(int number)
{
    if (number % 10 > 0)
    {
        var? thirdValue = number % 10;
        return thirdValue;
    }
    else
    {
        return null;
    }
}

showThirdValue(number);

var? thirdValue = showThirdValue(number);
if (number == null)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    Console.WriteLine ("number");
}