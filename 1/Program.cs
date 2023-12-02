// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11);

// Console.WriteLine(string.Join(", ", array));

// int k = new Random().Next(1, 11);
// Console.WriteLine(k);

// bool flag = false;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == k)
//         flag = true;
//     Console.WriteLine("Yes");
//     break;
// }
// if (flag == false)
//     Console.WriteLine("No");





// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11);

// Console.WriteLine(string.Join(", ", array));

// for (int i = 0; i < array.Length; i++)
//     array[i] *= (-1);

// Console.WriteLine(string.Join(", ", array));





// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11);
// Console.WriteLine(string.Join(", ", array));

// int[] new_array = new int[array.Length / 2];
// for (int i = 0; i < array.Length / 2; i++)
//     new_array[i] = array[i]* array[array.Length - 1 - i];

// Console.WriteLine(string.Join(", ", new_array));





// Console.Clear();
// int[] array = new int[3];

// int k = new Random().Next(100, 1000);
// Console.WriteLine(k);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = k % 10;
//     k /= 10;
// }

// Console.WriteLine(string.Join(", ", array));
