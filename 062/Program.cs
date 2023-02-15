// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

System.Console.WriteLine("Введите количество строк:"); 
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int k=Convert.ToInt32(Console.ReadLine());
int [,] a=Random2D(n,k);
P2DA (a);
Zamena (a);
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
void Zamena (int [,]a)
{
    for (int i=0;i<a.GetLength(0);i++)
        {
        for (int j=0;j<a.GetLength(1);j++) 
            if (a[i,j]%2==0) a[i,j]=a[i,j]*-1;  
        }
}  