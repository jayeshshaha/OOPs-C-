namespace console_app
{
    class AsyncEg
    {
        public async Task Task1(){
            await Task.Run(() => {
            Console.WriteLine("Task 1 Starting....");
            Thread.Sleep(4000);
            Console.WriteLine("Task 1 Completed");
            });
        }

        public async Task Task2(){
            await Task.Run(() => {
            Console.WriteLine("Task 2 Starting....");
            Thread.Sleep(3000);
            Console.WriteLine("Task 2 Completed");
            });
        }

        public async Task Task3(){
            await Task.Run(() => {
            Console.WriteLine("Task 3 Starting....");
            Thread.Sleep(2000);
            Console.WriteLine("Task 3 Completed");
            });
        }

        public async Task Task4(){
            await Task.Run(() => {
            Console.WriteLine("Task 4 Starting....");
            Thread.Sleep(1000);
            Console.WriteLine("Task 4 Completed");
            });
        }
    }
}




// class Program {
//   public static async Task Main() {
//     await Task2();
//     Task1();
//   }
  
//   public static void Task1(){
//       Console.WriteLine("Task 1");
//   }
  
//   public static async Task Task2(){
//       await Task.Run(() => {
//           Console.WriteLine("Task 2 Starting...");
//           Thread.Sleep(5000);
//           Console.WriteLine("Task 2 Ending...");
//       });
//   }
// }