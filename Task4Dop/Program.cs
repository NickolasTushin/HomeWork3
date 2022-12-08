Console.Clear();
Console.WriteLine("Введите количество кустов не меньше трех:  ");
int n = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;
while (n < 3 || n > 1000)
{
    Console.WriteLine("Вы ошиблись! \nВведите правильное кол-во кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] a = new int[n];                      // количество кустов
n = a.Length;
for(int i = 0;i < a.Length; i ++)
{
    a[i]= new Random().Next(5,20);         // все кусты с разным количеством ягод
    Console.WriteLine("Номер куста " + i + "     Количество ягод на нем     " + a[i]);        // вывел для сверки
}
Console.WriteLine("Введите номер куста: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0 || x >= a.Length) 
{
    x = 0;
}
int prev = x - 1;
if (prev <= 0) 
{
  prev = a.Length -1;
}
int next = x + 1;
if (next >= a.Length) 
{
  next = 0;
}
sum = a[x] + a[prev] + a[next];

    Console.Write($"Количестово ягод которые соберет модуль за один заход:   =  {sum}  " );