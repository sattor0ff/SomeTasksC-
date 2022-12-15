int n;
 n = Convert.ToInt32(Console.ReadLine());
int[] largest = new int[n];
for (int i = 0; i < n; i++)
{
    largest[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if(largest.Max()==largest[i])
    {
        System.Console.Write(i);
    }
}