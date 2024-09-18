using Fractions;

var f1 = new Fraction(3, 5);
var f2 = new Fraction(5);
var f3 = new Fraction(3.5);
var f4 = new Fraction(1, 6, 8);
var f5 = new Fraction(3, 1, 2);
var f6 = new Fraction(5.25);
double x = new Fraction(4, 100);

Console.WriteLine($"f1 = {f1}");
Console.WriteLine($"f2 = {f2}");
Console.WriteLine($"f3 = {f3}");
Console.WriteLine($"f4 = {f4}");
Console.WriteLine($"f5 = {f5}");
Console.WriteLine($"f6 = {f6}");
Console.WriteLine($"x = {x}");

Console.WriteLine($"f1+f2 = {f1 + f2}");
Console.WriteLine($"f2-f3 = {f2 - f3}");
Console.WriteLine($"f3-f2 = {f3 - f2}");
Console.WriteLine($"f3*f4 = {f3 * f4}"); 
Console.WriteLine($"f1/f2 = {f1 / f2}"); 
Console.WriteLine($"f3==f5 = {f3 == f5}");
Console.WriteLine($"f1!=f2 = {f1 != f2}");
Console.WriteLine($"f1<f2 = {f1 < f2}");
Console.WriteLine($"f2>f3 = {f2 > f3}");
Console.WriteLine($"f1<=f4 = {f1 <= f4}");
Console.WriteLine($"f2>=f5 = {f2 >= f5}");
Console.WriteLine($"f1^2 = {f1 ^ 2}");
Console.WriteLine($"f3^(-2) = {f3 ^ (-2)}");




