// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for(int i = 0; i< array.Length;i++)
{ 
    array[i]=new Random().Next(100, 999);
}
Console.WriteLine(string.Join(", ", array)); //Join работает только на массивах и листах
foreach(int i in array)
{
    if(i%2==0) 
    { 
        count++;
    }
}
Console.WriteLine($"количество четных чисел " +count);
