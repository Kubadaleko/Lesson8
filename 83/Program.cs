// 83. Подсчитать количество цифр среди вводимых с клавиатуры символов

string? s = Console.ReadLine();
int count = 0;
for (int i = 0; i < s.Length; i++)
{
    if (Char.IsDigit(s[i]))
        count++;
}
System.Console.WriteLine("количество цифр среди вводимых с клавиатуры символов " + count);