// Задача 41. Пользователь вводит М чисел с клавиатуры.
// Нужно посчитать сколько из этих чисел больше 0.

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
