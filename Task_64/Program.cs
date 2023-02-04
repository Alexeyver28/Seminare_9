// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//         // Выполнить с помощью рекурсии.


//         Console.Write("Введите число: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int m = 1;
//         OutputNumbers(m, n);

internal class Program
{
    private static void Main(string[] args)
    {
        void OutputNumbers(int m, int n)
        {
            if (m <= n)
            {
                OutputNumbers(m + 1, n);
                Console.Write($"{m} ");
            }
        }

        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = 1;
        OutputNumbers(m, n);
    }
}