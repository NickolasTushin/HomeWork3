Console.Clear();
Console.WriteLine("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;

while (n < 3 || n > 1000)

{
    Console.WriteLine("Вы ошиблись! \nВведите правильное кол-во кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] a = new int[n];               // количество кустов
n = a.Length;
for(int i = 0;i < a.Length; i ++)
{
    a[i]= new Random().Next(5,15);  // все кусты с разным количеством ягод
    Console.WriteLine(" " + i + " = " + a[i]);         // вывел для сверки
}

Console.WriteLine("Введите номер куста: ");
int x = Convert.ToInt32(Console.ReadLine());

    sum = a[x]+(a[x-1])+a[x+1];

Console.Write($"Количестово ягод которые соберет модуль за один заход:   =  {sum}  " );