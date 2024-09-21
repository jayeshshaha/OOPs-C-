namespace console_app
{
    abstract class Abstraction
    {
        public abstract void abstractMethod();
        public void regularMethod(){
            Console.WriteLine("RegularMethod");
        }
    }
}