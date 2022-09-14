// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
string num = Console.ReadLine();
int[] array = new int[num.Length];
for(int i = 0; i < num.Length; i++)
{
    array[i] = Convert.ToInt32(num[i].ToString());
}
Summa(array);

void Summa(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    System.Console.Write("Сумма цмфр в числе равна = ");
    System.Console.Write(sum);
}



