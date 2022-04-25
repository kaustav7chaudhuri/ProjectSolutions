using System;
class mat
{
    int i, j, m, n;
    int[,] a = new int[20, 20];
    public void get()
    {
        // m = 4;
        //n = 4;
        Console.WriteLine("Enter Row Value");
        m = int.Parse(Console.ReadLine());
     
        Console.WriteLine("Enter Column Value");
        n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter Elements one by one");
        for (i = 1; i <= m; i++)
        {
            for (j = 1; j <= n; j++)
            {
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Given Matrix is: \n");
        for (i = 1; i <= m; i++)
        {
            for (j = 1; j <= n; j++)
            {
                Console.Write("\t{0}", a[i, j]);
            }
            Console.Write("\n");
        }
    }
    public void diag()
    {
        int d;
        d = 0;
        if (m == n)
        {
            for (i = 1; i <= m; i++)
            {

                for (j = 1; j <= n; j++)
                {
                    if (i == j)
                    {
                        d = d + a[i, j];
                    }

                }
            }
            Console.WriteLine("Diagonal Sum= {0}", d);
        }
        else
        {
            Console.WriteLine("Can't Perform Diagonal Sum");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mat ma = new mat();
            ma.get();
            ma.diag();
            Console.Read();
        }
    }
}