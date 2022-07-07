int n, sum = 0;
Console.WriteLine("Ведите количество элементов массива ");
n = Convert.ToInt32(Console.ReadLine());
int[] array =  new int[n];

 Console.WriteLine("Массив получился ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i]%2 == 0)
    {
        sum = sum +1;
    }
} 
Console.WriteLine("[" + string.Join(", ", array) + "]");
 
Console.WriteLine("Колличество четных чисел в массиве ");
Console.WriteLine(sum);




// int n, count =0;
// Console.WriteLine("Ведите количество элементов массива ");
// n = Convert.ToInt32(Console.ReadLine());
// int[] array =  new int[n];
// Console.WriteLine("Напишите числа ");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array[i]%2 == 0)
//     {
//         count = count +1;
//     }
// } 

// Console.WriteLine(count);





