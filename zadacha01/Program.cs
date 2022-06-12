//Показать натуральные числа от M до N, N и M заданы
void NumbersFromMtoN (int minNumber, int maxNumber)
{
    Console.Write(maxNumber + " " );
    if (minNumber == maxNumber) return;
    else NumbersFromMtoN (minNumber, maxNumber - 1);
}
NumbersFromMtoN (1, 50);
Console.WriteLine();
