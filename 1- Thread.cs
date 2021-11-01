using System.Threading.Tasks;   //TPL - Task Parallel Library

void myFunct()
{
    Console.WriteLine("THREAD");
}

int returnSum(int i)
{
    return i + i;
}

Thread thread = new Thread(new ThreadStart(myFunct));   //OS allocates processor time, A thread execute any part of the code. 
thread.Start();

/*for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}
*/




//Thread thread1 = new Thread(new ThreadStart(returnSum)); //NOT POSSBILE, To do so we use TASK Class,
