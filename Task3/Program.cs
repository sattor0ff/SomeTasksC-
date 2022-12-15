int salary,n,k;
salary = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
if (n>5)
{
    k = salary*5/100;
    System.Console.WriteLine($"prosent = {k}");
}
else
{
    System.Console.WriteLine("not enough");
}