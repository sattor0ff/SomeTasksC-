double Factorial(int n)
{
  int res = 1;
  for (int i = 2; i < n; i++)
  {
    res*=i;
  }
  return res;
}
var n = Convert.ToInt32(Console.ReadLine());
double Sum = 0; 
for (int i = 1; i <= n; i++)
{
  Sum += 1/Factorial(i);
}
System.Console.WriteLine(Sum+1);
             