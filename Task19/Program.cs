Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
var str = number.ToString();

int start = 0;
int finish = str.Length - 1;

do
{
  if (str[start] == str[finish]) {
    start++;
    finish--;
  } else {
    Console.WriteLine("Это не палиндром!");
    return;
  }
}
while (start < finish);

Console.WriteLine("Это палиндром!");