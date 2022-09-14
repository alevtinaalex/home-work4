//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


System.Console.WriteLine("Введите число А= ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B= ");
int b = Convert.ToInt32(Console.ReadLine());
Stepen(a);

void Stepen(int n)
{
    int n1=n;
for(int step =1; step < b; step++)
{
    n = n*n1;
}
System.Console.WriteLine(n);
}