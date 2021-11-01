using System.Threading.Tasks;   //TPL - Task Parallel Library

void workLoad(string msg)
{

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i + " " + msg);
        Thread.Sleep(1000);
    }

}



Task waitTask = new Task(() => workLoad("first"));
waitTask.Start();


Task waitTask2 = new Task(() => workLoad("second"));
waitTask2.Start();
waitTask2.Wait(5000);   // 5 seconds wait to reach below statements

Console.WriteLine("Main method complete. Press any key to finish.");
Console.ReadKey();
