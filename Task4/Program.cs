int n, k, kf=1, nf=1, nkf=1;

n = Convert.ToInt32(Console.ReadLine());
k = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n; i++)
{
    nf*=i;
}for(int i=1; i<=k; i++)
{
    kf*=i;
}for(int i=1; i<=n-k; i++)
{
    nkf*=i;
}

System.Console.WriteLine($"{nf/(kf*nkf)}");