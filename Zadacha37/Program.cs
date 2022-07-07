int n;
Console.WriteLine("Напишите кол-во чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Напишите числа: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i <= array.Length / 2; i++)
{
    Console.WriteLine(array[i] * array[array.Length - i - 1]);
}
