//Проверка на простое число
bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

//Метод, выводящий бОльшее простое число
int StartCouratine(int f_num, int s_num) {
    int l_num = 0;
    for (int i = f_num; i!=s_num+1; i++)
    {
        if(IsPrime(i))
            l_num=i;
    }
    return l_num;
}

//Тело программы
Console.WriteLine("Введите первое число"); int f_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число"); int s_num = Convert.ToInt32(Console.ReadLine());
if (s_num<f_num)
{
    Console.WriteLine("Второе число больше первого.");
}
else
{
   int l_num = StartCouratine(f_num, s_num);
    Console.WriteLine($"Наибольшее простое число: {l_num}");
}