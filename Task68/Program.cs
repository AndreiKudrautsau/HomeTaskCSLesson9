// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное целое число # 1:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число # 2:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne < 0 || numberTwo < 0) Console.WriteLine("Внимание ошибка!!! Введите неотрицательное целое число");
else
{
    int numberAckermann = Ackermann(numberOne, numberTwo);
    Console.WriteLine($"Результат вычисления функции Аккермана для чисел {numberOne} и {numberTwo} равен: {numberAckermann}");

}

// метод
int Ackermann(int num1, int num2)
        {
            if (num1 == 0)
            {
                return num2 + 1;
            }else if (num2 == 0)
            {
                return Ackermann(num1 - 1, 1);
            }else
            {
                return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
            }
        }