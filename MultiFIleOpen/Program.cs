using System.Diagnostics;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;


Thread t1 = new Thread(OpenFIle1);
Thread t2 = new Thread(OpenFIle2);
Thread t3 = new Thread(OpenFIle3);

// start the thread
t1.Start();
t2.Start();
t3.Start();


// do some other work in the main thread
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Main thread doing some work");
    Thread.Sleep(100);
}

// wait for the worker thread to complete
t1.Join();
t2.Join();
t3.Join();

Console.WriteLine("Done");
static void OpenFIle1()
{
    Process.Start(@"explorer.exe", @"C:\Users\trash\source\repos\lessons\MultiFIleOpen\file1.txt");

    Thread.Sleep(100);
}
static void OpenFIle2()
{
    Process.Start(@"explorer.exe", @"C:\Users\trash\source\repos\lessons\MultiFIleOpen\file2.txt");

    Thread.Sleep(100);
}
static void OpenFIle3()
{
    //Process.Start(@"C:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe", @"C:\Users\trash\Downloads\daily routine.jpg");
    Process.Start(@"explorer.exe", @"C:\Users\trash\Downloads\daily routine.jpg");

    Thread.Sleep(100);
}