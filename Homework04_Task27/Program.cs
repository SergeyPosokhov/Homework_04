//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
Console.WriteLine("Введите какое-нибудь число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SumNumbers(string msg, int sum)
{
    while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.Write(msg + sum);
}
SumNumbers("Сумма цифр в числе равняется ", sum);
