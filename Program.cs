using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ban hay nhap vao 1 so");
        int so = Convert.ToInt32(Console.ReadLine());
        if(so<5)
        {
        switch (so)
        {
            case 1:
                Console.WriteLine("*");
                Console.WriteLine("**");
                Console.WriteLine("***");
                Console.WriteLine("****");
                Console.WriteLine("*****");        
                Console.WriteLine("******");
                break;
            case 2:        
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                break;
            case 3:        
                Console.WriteLine("******");
                Console.WriteLine("******");
                Console.WriteLine("******");
                break;
            case 4:        
                Console.WriteLine("******");
                Console.WriteLine("*====*");
                Console.WriteLine("*====*");
                Console.WriteLine("*====*");
                Console.WriteLine("*====*");
                Console.WriteLine("******");
                break;
            case 0:        
                Environment.Exit(so);
                break;
            default:
                Console.WriteLine("gia tri");
                break;
        }
        
        }
        else
        {
            Console.WriteLine("nhap sai khoang roi");
        }
    }
}