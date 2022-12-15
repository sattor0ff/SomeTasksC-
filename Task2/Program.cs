int a, b, c, d, sh;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

sh = (c*100+d)-(a*100+b);

Console.WriteLine($"{sh/100} somoni {sh%100} diram");