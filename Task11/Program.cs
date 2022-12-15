using System;
int n;
 n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(arr);
Array.Reverse(arr);
for (int i = 0; i < 1; i++)
{
    System.Console.Write($"{arr[i]} ");
}