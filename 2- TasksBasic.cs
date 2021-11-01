using System.Threading.Tasks;   //TPL - Task Parallel Library


void CallMe() {
    Console.WriteLine("Called Me");
}

void CallMe2(object msg) { //Parameters
    Console.WriteLine(msg);
}

//Task is a higher level concept than Thread.

//Action Delegate (Passing function as arguement)
Task task = new Task(new Action(CallMe));

//anonymous function  
Task task1 = new Task(delegate
{
    CallMe();
    });

//lambda expression  
Task task2 = new Task(() => CallMe());

task.Start();       //Starting Task
task1.Start();
task2.Start();


Task myTask1 = new Task(() =>
{
    CallMe2("Call 1");
});


Task myTask2 = new Task(() =>
{
    CallMe2("Call 2");
});


Task myTask3 = new Task(() =>
{
    CallMe2("Call 3");
});

myTask1.Start();
myTask2.Start();
myTask3.Start();


Console.WriteLine("Main method complete. Press any key to finish.");
Console.ReadKey();
