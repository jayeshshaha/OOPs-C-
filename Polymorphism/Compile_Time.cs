// Polymorphism indeed refers to "many forms," and sometimes methods across different classes may have similar or even identical implementations. 

namespace console_app
{
    class Compile_Time
    {
        public void Area(int a){
            Console.WriteLine(a * a);
        }

        public void Area(int a, int b){
            Console.WriteLine(a * b);
        }
    }
}