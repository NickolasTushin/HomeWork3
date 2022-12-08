Console.Clear();
Console.WriteLine("Введите количество кустов не меньше трех:  ");
int n = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
int sum1 = 0;
int sum2 = 0;
int i = 0;
while (n < 3 || n > 1000)
{
    Console.WriteLine("Вы ошиблись! \nВведите правильное кол-во кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
int[] a = new int[n];                      // количество кустов
n = a.Length;
for(i = 0;i < a.Length; i ++)
{
    a[i]= new Random().Next(5,20);         // все кусты с разным количеством ягод
    Console.WriteLine("Номер куста " + i + "     Количество ягод на нем     " + a[i]);        // вывел для сверки
}

if (sum > sum1)
        sum1 = sum;
    else
        sum = sum1;
    if (i == n - 1)
        sum2 = a[0] + a[1] + a[n - 1];
        if (a[1] < a[n - 2])
            sum2 = a[0] + a[n - 2] + a[n - 1];
    if (sum2 > sum)
        sum = sum2;
    Console.Write($"Количестово ягод которые соберет модуль за один заход:   =  {sum}  " );