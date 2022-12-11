// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Random rnd = new Random();
Console.WriteLine("Ввод чисел");
int max;
int min;
int a;
int[] array = new int[5];
for(int i = 0; i<5 ;i++){ array[i]=rnd.Next(0, 100);}
max=array[0];
min=max;
foreach(int i in array) //i=элементу массива
{
  if(max<i){max=i;}
  if(min>i){min=i;}
}
a=max-min;
Console.WriteLine($"[ {array[0]}, {array[1]}, {array[2]} {array[3]}, {array[4]} ]");
Console.WriteLine($"минимальное " +min);
Console.WriteLine($"максимальное " +max);
Console.WriteLine($"разница между максимальным и минимальным " +a);

