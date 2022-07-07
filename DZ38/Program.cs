int n;
double max = 0, min = 1000, razn = 0;
Console.WriteLine("Ведите количество элементов массива ");
n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Console.WriteLine("Массив получился ");
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];

}
razn = max-min;

Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("max =");
Console.WriteLine(max);
Console.WriteLine("min =");
Console.WriteLine(min);
Console.WriteLine("Разница между max и min ", razn);
Console.WriteLine(razn);