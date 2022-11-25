/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/ 

int ReadInt (string msg)
    {
        Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }
int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите натуральное число B: ");
int result = A;

for (int i = 1; i < B ; i++)
    {
        result *= A;
    }

if (B < 1) Console.WriteLine("Введенное число B должно быть больше 0");

else Console.Write($"A в степени B равно: {result}");

 /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (number < 0) number = -number;
int n = number;
while (n > 0)
    {
        sum += n % 10;
        n = (n - n % 10)/10;
    }
Console.WriteLine($"Сумма цифр введенного числа равна: {sum}");

 /*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
5 -> [1, 2, 5, 7, 19] 
3 -> [6, 1, 33]*/

int[] PrintArray (int[] name)
{
    for (int j = 0; j < name.Length; j++)
    {
        Console.Write(name[j] + " ");
    }
    return name;
}

Console.WriteLine("Введите число больше 0: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0) Console.WriteLine("Введенное число должно быть больше 0");

else 
{
    int[] array = new int [N];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 100);
        }
PrintArray(array);
}