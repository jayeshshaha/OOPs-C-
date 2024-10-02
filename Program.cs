using Name;

namespace console_app
{
    class Program
    {
        public static async Task Main(string[] args){
            AsyncEg obj = new AsyncEg();
            Task t1 = obj.Task1();
            Task t2 = obj.Task2();
            Task t3 = obj.Task3();
            Task t4 = obj.Task4();
            await Task.WhenAll(t1,t2,t3,t4);
        }
    }
}