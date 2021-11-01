using System.Threading.Tasks;   //TPL - Task Parallel Library


//createing the tasks  
Task taskA = new Task(() =>
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Task 1 - iteration {0}", i);

        //sleeping for 1 second  
        Thread.Sleep(1000);
    }
    Console.WriteLine("Task 1 complete");
});

Task taskB = new Task(() =>
{
    Console.WriteLine("Task 2 complete");
});

// starting the tasks  
taskA.Start();
taskB.Start();


//if any task completed
int taskIndex = Task.WaitAny(taskA, taskB);
Console.WriteLine("Task Completed - array index: {0}", taskIndex);




//waiting for both tasks to complete  
Console.WriteLine("Waiting for tasks to complete.");
Task.WaitAll(taskA, taskB); //Waiting here for all tasks completion
Console.WriteLine("Tasks Completed.");
