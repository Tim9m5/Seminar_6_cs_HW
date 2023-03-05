// Задача 41. Пользователь вводит М чисел с клавиатуры.
// Нужно посчитать сколько из этих чисел больше 0.
/*
Console.WriteLine("Введите солько чисел вы хотите проверить: ");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите проверяемые числа, каждое на новой строке: ");
int [] array = new int [size];
        
for ( int i = 0; i < size; i++)
{
    int num = Convert.ToInt32 ( Console.ReadLine());
    array [i] = Convert.ToInt32(num);
}


Console.WriteLine(String.Join(";", array));
int count = 0;
{
    for ( int i=0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            count = count+1;
        }
    }
}
Console.WriteLine($"Введено {count} положительных чисел ");
*/
//----------------------------------------------------------------

// Задача 43. Напишите программу, которая найдет точку пересечения
// двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2.
// Значения k1, k2, b1, b2 задаются пользователем.
/*
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    Console.WriteLine($"Координаты пересечения прямых: x = {x}; y = {y}");
}

*/

