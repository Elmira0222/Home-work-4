/*  Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16           */


int A;
Console.Write("Enter first number: ");
int.TryParse(Console.ReadLine()!, out A);
int B;
Console.Write("Enter second number: ");
int.TryParse(Console.ReadLine()!, out B);
Console.Write($"The result of raising the first number to a natural power of the value of the second number will be: {Exp(A,B)}");
int Exp(int A, int B)
{
int Numb = A;
for (int i = 1; i < B; i++)
Numb = Numb*A;
return Numb;

}