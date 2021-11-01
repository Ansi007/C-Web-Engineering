using System.Threading.Tasks;

CancellationTokenSource cancellationToken = new CancellationTokenSource();      //Creating Cancelations
CancellationToken token = cancellationToken.Token;

Task<dynamic> returnTask = new Task<dynamic>(() => {
    for (int i = 0; i < 10; i++)
    {

        if (token.IsCancellationRequested)
        {
            Console.WriteLine("Cancel() called.");
            return 0;
        }
        Thread.Sleep(1000);
        Console.WriteLine(i);
    }
    Console.WriteLine("Task Completed");
    return 0;
}, token);

returnTask.Start();

Console.WriteLine("Press any key to cancel");
Console.ReadKey();
cancellationToken.Cancel();     //Cancelling Task
Console.ReadKey();
Console.WriteLine("Came Here");

