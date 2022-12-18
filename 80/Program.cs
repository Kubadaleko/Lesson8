// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

void ASCII(int a, int b)
{
    for (int i = a; i <= b; i++)
        Console.WriteLine(i.ToString() + "-й символ кодировка ASCII: "
        + Convert.ToString(i, 2));
}
ASCII(32, 122);