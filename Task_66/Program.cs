// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
     int SumNumbers(int n, int m) 
{ 
     if (n != m) 
     {
         return (n+SumNumbers(n - 1, m)); 
     } 
  else return n;
}
    Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(n, m); 
Console.Write(sum);
