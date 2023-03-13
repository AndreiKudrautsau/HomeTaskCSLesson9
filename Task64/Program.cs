// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите '1', чтобы получить список натуральных чисел от 1 до {number} в порядке убывания, и '0' - в порядке возврастания:");
int choice = Convert.ToInt32(Console.ReadLine());
if (number <=0 || choice != 1 && choice != 0) Console.WriteLine("Внимание ошибка!!! Неверно введены числа");    
else
        {
            PrintMessage ("В соответствии с Вашим выбором список имеет следующий вид:");
            ListNumber (number, choice);
        }

// метод
void ListNumber (int num, int choi)
{
    
    if (num < 1) return;
    if (choi == 1)
    {
    Console.Write ($"{num, 3} ");
    ListNumber (num - 1, choi);
    }
    if (choi == 0)
    {
    ListNumber (num - 1, choi); 
    Console.Write ($"{num, 3} ");
    };
    
}

void PrintMessage (string message)
{
    Console.WriteLine (message);
}