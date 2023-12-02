// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(10, 100);

// Console.WriteLine(string.Join(", ", array));

// int k = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 20 && array[i] < 90)
//         k = k + 1;
// }

// Console.Write(k);


//---------------------------------------------------------------------------------------------------------------------------------------


// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 100);

// Console.WriteLine(string.Join(", ", array));

// int k = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)
//     k = k + 1;
// }

// Console.Write(k);


//---------------------------------------------------------------------------------------------------------------------------------------
// Console.Clear();

// double[] array = new double[5];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 100) + Math.Round(new Random().NextDouble(), 1);

// Console.WriteLine("Элементы массива: " + string.Join("; ", array));

// double min = array[0];
// double max = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min)
//         min = array[i];
// }

// Console.WriteLine("Минимальное число: " + min);

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//         max = array[i];
// }
// Console.WriteLine("Максимальное число: " + max);

// double result = Math.Round(max - min, 1);

// Console.WriteLine("Разность этих чисел: " + result);


//---------------------------------------------------------------------------------------------------------------------------------------


// Console.Clear();
// int[] array = new int[5];

// int k = new Random().Next(1, 100000);
// Console.WriteLine(k);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = k % 10;
//     k /= 10;
// }

// for (int i = 0; i < array.Length; i += 1)
// {
//     int temp = array[i];
//     array[i] = array[array.Length - 1];
//     array[array.Length - 1] = temp;
//     break;
// }


// Console.WriteLine(string.Join(", ", array));