int n, sum = 0, count = 0, index = 1;
Console.WriteLine("Ведите количество элементов массива ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.WriteLine("Массив получился ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);

}
while (index < array.Length)
{
    count = count+1;
    sum = sum + array[index];
    index=index+2;

}
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Сумма элементов стоящих на нечетных позициях ");
Console.WriteLine(count);
Console.WriteLine("Сумма элементов  ");
Console.WriteLine(sum);