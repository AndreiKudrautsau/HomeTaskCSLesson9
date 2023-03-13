// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число # 1:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число # 2:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne <= 0 || numberTwo <= 0) Console.WriteLine("Внимание ошибка!!! Введите натуральное число");
else
{
    int sumNumber = SumNumber(numberOne, numberTwo);
    Console.WriteLine($"В соответствии с Вашим выбором сумма натуральных элементов в промежутке от {numberOne} до {numberTwo} равна: {sumNumber}");

}

// метод
int SumNumber(int num1, int num2)
{
    int sum = num1;
    if (num1 < num2)
    {
        sum = num1 + SumNumber(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        sum = num2 + SumNumber(num1, num2 + 1);
    }
    return sum;
}