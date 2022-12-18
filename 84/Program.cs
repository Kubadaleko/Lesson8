// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
//  Вычислить сумму цифр введенного числа

string? number = Console.ReadLine();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    if (Char.IsDigit(number[i]))
        sum = number[i] + sum - 48;
    else
    {
        System.Console.WriteLine("Запись не верная");
        return;
    }
}
System.Console.WriteLine("число " + number +
" является правильной записью целого числа, сумму цифр которого " + sum);



