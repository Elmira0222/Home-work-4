/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
в числе.

452 -> 11
82 -> 10
9012 -> 12  */

int A;
Console.Write("Enter the number whose sum you want to know: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write($"The sum of all the values ​​of the number you entered is equal to {SumAllNumb(A)}");
int SumAllNumb(int _A)
{
    int Numb = 0;
    int NewNumb = _A;
    while (NewNumb > 0)
    {
        Numb += NewNumb % 10;
        NewNumb /= 10;
    }
    return Numb;
}