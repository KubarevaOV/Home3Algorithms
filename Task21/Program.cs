
Console.WriteLine("Введите X1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

var dx = x2 - x1;
var dy = y2 - y1;
var dz = z2 - z1;

var s = dx*dx + dy*dy + dz*dz;
var distance = Math.Sqrt(s);

Console.WriteLine("Дистанция между точками = {0}", distance);