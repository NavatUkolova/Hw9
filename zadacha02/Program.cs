//Найти сумму элементов от M до N, N и M заданы
int SumofNumbers(int M, int N)
{
    if(M ==N) return N;
    else return M + SumofNumbers(M + 1, N);
}
Console.WriteLine(SumofNumbers(1, 10));
