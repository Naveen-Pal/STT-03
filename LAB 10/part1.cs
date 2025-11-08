using System;
using System.Diagnostics.Metrics;

class Program
{
    private int data;
    static int counter=0;
    // Constructor
    public Program()
    {
        counter += 1;
        Console.WriteLine("Constructor Called.");
        Console.WriteLine(counter);
    }

    // Destructor
    ~Program()
    {
        counter -= 1;
        Console.WriteLine("Object Destroyed");
        Console.WriteLine(counter);
    }

    public void show_data()
    {
        Console.WriteLine("Data: " + data);
    }

    public void set_data(int x)
    {
        data = x;
    }
    public static void Run()
    {
        Program p1 = new Program();
        Program p2 = new Program();
        Program p3 = new Program();
        p1.set_data(10);
        p2.set_data(20);
        p3.set_data(30);

        p1.show_data();
        p2.show_data();
        p3.show_data();
    }
    public static void Main(string[] args)
    {
        Run();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Thread.Sleep(100);
    }
}
