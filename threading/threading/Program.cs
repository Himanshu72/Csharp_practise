using System;
using System.Threading;
using System.Threading.Tasks;
namespace threading
{
    class Program
    {
       static void Main(string[] args)
        {
            /*  
              Console.WriteLine("Hello World 1");
              Thread.Sleep(1000);
              Console.WriteLine("Hello World 2");
              Thread.Sleep(1000);
              Console.WriteLine("Hello World 3");
            */

            //new Thread(()=> {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Hello World");
            //}).Start();
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Hello World 1");
            //}).Start();
            //new Thread(() => {
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Hello World 2");
            //}).Start();

            //var taskCompletionSource = new TaskCompletionSource<bool>();
            //new Thread(() => {
            //    Thread.Sleep(1000);    
            //    taskCompletionSource.TrySetResult(true); 
            //}).Start();
            //var result = taskCompletionSource.Task.Result;
            //Console.WriteLine($"Result:{result}");

            //ThreadPool.QueueUserWorkItem(o =>
            //{
            //    Console.WriteLine("THread Pool");
            //});
             Task.Run(() =>
            {
                Console.WriteLine("Task Running");
            });
        }
    }
}
