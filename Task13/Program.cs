int a, n;
 a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
 n = Convert.ToInt32(Console.ReadLine());
 for (int i = 0; i < a; i++)
{
    if (n == arr[i])
    {
    System.Console.Write("YES");
    }
}
