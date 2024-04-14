using System.Threading;

namespace Practice_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;


            Task cancellationTask = Task.Run(() =>
            {
                Console.WriteLine("Press 'X' to cancel tasks...");
                while (Console.ReadKey(true).Key != ConsoleKey.X) ;
                tokenSource.Cancel();
            });


            Task[] tasks = new Task[10];
            for (int i = 1; i <= 10; i++)
            {
                int taskNumber = i;
                tasks[i - 1] = Task.Run(() => WriteToFile(taskNumber, token));
                await Task.Delay(100); 
            }

            await Task.WhenAll(tasks);
            await cancellationTask;

        }

        static void WriteToFile(int taskNumber, CancellationToken cancellationToken)
        {
            string fileName = Path.Combine(@"C:\Users\lukaa\Desktop\New folder (2)\Day_28 (Async Programming)\Practice_1\", taskNumber + ".txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        writer.WriteLine($"Task {taskNumber}");
                        writer.Flush(); 
                        Thread.Sleep(taskNumber * 100); 
                    }
                }
            }
            catch (OperationCanceledException)
            {
                
            }
        }
    }
}
