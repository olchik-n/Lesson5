// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum=0;
for(int i = 0; i< array.Length;i++)
{ 
    array[i]=new Random().Next(-100, 100);
    if(i%2 !=0)
    sum +=array[i];
}
Console.WriteLine(string.Join(", ", array)); //Join работает только на массивах и листах
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях " +sum);

