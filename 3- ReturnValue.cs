using System.Threading.Tasks;
	
int returnSum(int a)
{
    return a + 2;
}

Task<int> returningSumTask = new Task<int>(() => { return (returnSum(2)); });
returningSumTask.Start();
Console.WriteLine(returningSumTask.Result);
