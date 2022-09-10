//-----------------------------Exercise # 25--------------------------------------------------------------
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16
*/
// ----------------------------SOLUTION-------------------------------------------------------------------
/*
double power(double A, int B) // Решение через цикл
{
    double result = 1;
    int i = 1;
    while (i <= B)
    {
        result = result * A;
        i++;
    }
    return result;
}
try
{
    System.Console.Write("Введите число = ");
    double a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите степень = ");

    int b = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(power(a, b));


}
catch
{
    System.Console.WriteLine("Введено не число, или число больше, чем может вместить int");
}
*/
//-----------------------------Exercise # 27--------------------------------------------------------------
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// ----------------------------SOLUTION-------------------------------------------------------------------
int charSum(double N)
{
    //объявляю переменные
    double mutable = N;  // создаем копию вводимого
    int summary = 0;
    while (mutable % 1 != 0)    // переводим число с запятыми в целое
    {
        mutable = mutable * 10;
    }
    int countOfCharInNumber = Convert.ToInt32(Math.Log(mutable, 10) + 1);   // Находим количество цифр в числе
    long[] massiveOfNumber = new long[countOfCharInNumber];
    for (int i = 0; i < countOfCharInNumber; i++)   //Насыщаем массив цифрами числа и вычисляем их сумму
    {
        massiveOfNumber[i] = Convert.ToInt64(mutable) / Convert.ToInt32(Math.Pow(10, i)) % 10;
        summary = summary + Convert.ToInt32(massiveOfNumber[i]);
    }
    return summary;
}
try
{
    System.Console.Write("Введите число = ");
    double a = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(charSum(a));
}
catch
{
    System.Console.WriteLine("Введено не число, или число больше, чем может вместить double");
}