//randomdouble + random next

// for (int i = 0; i < arr.Length - 1; i += 2)
// {
//     int temp = arr[i];
//     arr[i] = arr[i + 1];
//     arr[i + 1] = temp;
// }


Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10, 100);

Console.WriteLine(string.Join(", ", array));

int k = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 20 && array[i] < 90)
        k = k + 1;
}

Console.Write(k);

