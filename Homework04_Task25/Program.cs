// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

int Power(int a, int b)
{
    int power = a;
    int i = 1;
    while(i<b)
    {
        power = power * a;
        i++;    
    }
        if(i == b)
        {
            Console.WriteLine($"Число {a} в степени {b} будет равно {power}");
        }

    return power;
}
Power(a, b);

