Console.Write("Введите число №1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) Console.WriteLine($"Число {a} максимальное");
else if (a == b) Console.WriteLine("Числа равны");
else Console.WriteLine($"Число {b} максимальное");

