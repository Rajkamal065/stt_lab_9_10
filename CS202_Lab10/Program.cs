using System;

public class Program
{
    // Private integer field
    private int data;

    // Static counter to track active objects
    private static int activeObjects = 0;

    // Constructor: initializes object and increments counter
    public Program()
    {
        Console.WriteLine("Constructor Called.");
        activeObjects++;
        Console.WriteLine($"Number of active objects: {activeObjects}");
    }

    // Destructor: prints message and decrements counter
    ~Program()
    {
        Console.WriteLine("Object Destroyed.");
        activeObjects--;
        Console.WriteLine($"Number of active objects: {activeObjects}");
    }

    // Method to set data
    public void set_data(int x)
    {
        data = x;
    }

    // Method to display data
    public void show_data()
    {
        Console.WriteLine($"Data value is: {data}");
    }

    public static void Main(string[] args)
    {
        // Object creation inside separate method scope
        CreateObjects();

        // Force garbage collection to trigger destructors
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    // Method to create and use objects
    static void CreateObjects()
    {
        // Dynamically create three objects
        Program obj1 = new Program();
        Program obj2 = new Program();
        Program obj3 = new Program();

        // Assign values
        obj1.set_data(10);
        obj2.set_data(20);
        obj3.set_data(30);

        // Display values
        obj1.show_data();
        obj2.show_data();
        obj3.show_data();
    }
}
