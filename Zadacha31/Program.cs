// void factorial(int[]count){
//     int count =1;
//     for (int i = 0; i < = n; i++)
//     count = count*i;
//     {
//         count = count*i;
//     }
// }




int [] array = new int[12];
int[] sum = new int[2];
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-9, 9); //8 длина массива
        index++;
    }
}

void PrintArray(int[]col){
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    for (int i = 0; i < col.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        if (array[i] > 0) 
            sum[0] = sum[0] + array[i];
        else 
            sum[1] = sum[1] + array[i];
    }
   
}
FillArray(array);
PrintArray(array);

  
Console.WriteLine("Суммы положительных цифр = {0} и отр. = {1}", sum[0], sum[1]);





// int[] array = new int[12];
// int[] sum = new int[2];
// void FillArray(int[] collection, int[] sum)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//         if (array[i] > 0) 
//             sum[0] = sum[0] + array[i];
//         else 
//             sum[1] = sum[1] + array[i];
//     }
// }
// FillArray(array, sum);
// Console.WriteLine("Суммы положительных цифр = {0} и отр. = {1}", sum[0], sum[1]);
