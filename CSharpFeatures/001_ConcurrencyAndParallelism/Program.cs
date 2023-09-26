// See https://aka.ms/new-console-template for more information

Console.WriteLine("Concurrency and Parallelism Demo");
Console.WriteLine(Environment.NewLine);


/* Initial Code*/
//PerformTask1();
//PerformTask2();

Task.Factory.StartNew(PerformTask1);
Task.Factory.StartNew(PerformTask2);

Task.Run(() => PerformTask1());
Task.Run(() => PerformTask2());

/*
     Task.Run runs the program in a seperate thread pool
     Task.Factory.StartNew has much control over Task.Run and can do fine grain configurations
*/

Console.Write("Enter your name : ");
var name = Console.ReadLine();
Console.WriteLine($"Hello! {name}");


Console.Read();








 static async void PerformTask1()
{
    // Task.Delay(5000).Wait(); Previous Code without async
    await Task.Delay(5000);
    Console.WriteLine("First Task Completed");
    Console.WriteLine("-------------------------");
}

static async void PerformTask2()
{
    // Task.Delay(5000).Wait();
    await Task.Delay(5000);
    Console.WriteLine("Second Task Completed");
    Console.WriteLine("-------------------------");
}