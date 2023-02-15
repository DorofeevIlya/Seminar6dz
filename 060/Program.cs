// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами

System.Console.WriteLine("Введите количество строк:"); 
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int m=Convert.ToInt32(Console.ReadLine());
int [,] a=Random2D(n,m,0,9);
P2DA (a);
int[,] Random2D (int m, int n, int min, int max)
{
    int [,] a=new int [m,n];
    Random random=new Random(); 
    for (int i=0;i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}
void P2DA (int [,]a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)   
        System.Console.Write($"{a[i,j],5}");
    System.Console.WriteLine();
    }
}