using System.Threading.Tasks;   //TPL - Task Parallel Library

//creating the tasks  
Task taskAA = new Task(() =>
{
    NullReferenceException exception = new NullReferenceException();
    exception.Source = "taskAA";
    throw exception;
});

Task taskBB = new Task(() =>
{
    throw new IndexOutOfRangeException();
});

Task taskCC = new Task(() =>
{
    Console.WriteLine("Task 3");
});

//starting the tasks  
taskAA.Start();
taskBB.Start();
taskCC.Start();

//waiting for all the tasks to complete              
try
{
    Task.WaitAll(taskAA, taskBB, taskCC);
}
catch (AggregateException ex)
{
    //enumerate the exceptions  
    foreach (Exception inner in ex.InnerExceptions)
    {
        Console.WriteLine("Exception type {0} from {1}", inner.GetType(), inner.Source);
    }
}

Console.WriteLine("Main method complete. Press any key to finish.");
Console.ReadKey();
