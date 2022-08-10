Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int v = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int d = Convert.ToInt32(Console.ReadLine());


int max = a;

if (a > max) max = a;
if (v > max) max = v;
if (d > max) max = d;

Console.Write("Максимальное число = ");
Console.WriteLine(max);

