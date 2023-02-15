// 68. Написать программу, которая обменивает элементы первой строки и последней строки

System.Console.Write("Введите количество строк:"); 
int n=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов:");
int k=Convert.ToInt32(Console.ReadLine());
int [,] a=Random2D(n,k);
P2DA (a);
Zamena (a,n);
System.Console.WriteLine();
P2DA (a);
int[,] Random2D (int n, int k)
{
    int [,] a=new int [n,k];
    Random random=new Random(); 
    for (int i=0;i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(0,10);
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
void Zamena (int [,]a, int n)
{
    int g=n-1;
    for (int i=0;i<a.GetLength(0);i++)
        {
        for (int j=0;j<a.GetLength(1);j++) 
        {
           if (i==0 && j>=0)
           {
            int t=a[i,j];
            a[i,j]=a[i+g,j];
            a[i+g,j]=t;
            }  
        }
        }
}  

