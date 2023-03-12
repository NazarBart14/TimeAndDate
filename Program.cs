namespace Sistem_Programe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Час: {currentTime.ToLongTimeString()}");
            Console.WriteLine($"Дата: {currentTime.ToLongDateString()}\n");

            
            Task task1 = new Task(() => Console.WriteLine($"{DateTime.Now.ToLongTimeString()}"));
            task1.Start();

            
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine($"{DateTime.Now.ToLongTimeString()}"));

           
            Task task3 = Task.Run(() => Console.WriteLine($"{DateTime.Now.ToLongTimeString()}"));

            
            Task.WaitAll(task1, task2, task3);
        }
    }
}