//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] x)
{
  int count = 0;
  int length = x.Length;
  while (count <  length)
  {
    x[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArray(int[] y)
{
  int count2 = y.Length;
  int index = 1;
  while(index < count2){
    Console.WriteLine($"{index} \t {y[index]}");
    index++;
  }
} 

int[] array = new int[x + 1];
FillArray(array);
PrintArray(array);
