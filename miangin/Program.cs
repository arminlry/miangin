// armin liryaee
//miangin 
// tamrin 4
char z = ' ';

do
{
    Console.Write("enter your math score:");
    double a = Convert.ToInt32(Console.ReadLine());
    double b = a * 4;
    Console.WriteLine(z);
    Console.Write("enter your physics score:");
    double c = Convert.ToInt32(Console.ReadLine());
    double d = c * 3;
    Console.WriteLine(z);
    Console.Write("enter your english score:");
    double e = Convert.ToInt32(Console.ReadLine());
    double f = e * 3;
    Console.WriteLine(z);
    Console.Write("enter your basics of programming score:");
    double g = Convert.ToInt32(Console.ReadLine());
    double h = g * 3;
    Console.WriteLine(z);
    Console.Write("enter your software exam score:");
    double i = Convert.ToInt32(Console.ReadLine());
    double j = i * 3;
    Console.WriteLine(z);
    Console.Write("enter your mobile programming score:");
    double k = Convert.ToInt32(Console.ReadLine());
    double l = k * 3;
    Console.WriteLine(z);
    Console.Write("enter your physical education score:");
    double m = Convert.ToInt32(Console.ReadLine());
    double n = m * 1;
    Console.WriteLine(z);
    Console.Write("enter your farsi score:");
    double o = Convert.ToInt32(Console.ReadLine());
    double p = o * 3;
    Console.WriteLine(z);
    Console.Write("enter your logic circuits score:");
    double q = Convert.ToInt32(Console.ReadLine());
    double r = q * 3;
    Console.WriteLine(z);
    Console.Write("enter your internet engineering score:");
    double s = Convert.ToInt32(Console.ReadLine());
    double t = s * 3;
    double x = (b + d + f + h + j + l + n + p + r + t) ;
    double A = x / 29;
    Console.WriteLine(z);
    Console.WriteLine(A);
    Console.WriteLine(z);
    Console.WriteLine("do you want to continue?");

} while (Console.ReadLine() == "y");