Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++) {
    Console.WriteLine("Куб числа {0} равен {1}", i, Math.Pow(i, 3));
}