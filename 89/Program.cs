// 89. Подсчитать сумму цифр, встречающихся в строке

string? s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
{
    if (Char.IsDigit(s[i]))
        sum = s[i] + sum - 48;
}
System.Console.WriteLine("сумма чисел " + sum);