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