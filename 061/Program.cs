// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.WriteLine("Введите количество строк:"); 
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int m=Convert.ToInt32(Console.ReadLine());
double [,] a=Random2D(n,m);
P2DA (a);
double[,] Random2D (int m, int n)
{
    double [,] a=new double [m,n];
    Random random=new Random(); 
    for (int i=0;i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.NextDouble();
    return a;
}
void P2DA (double [,]a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)   
        System.Console.Write($"{a[i,j],6:F2}");
    System.Console.WriteLine();
    }
}
