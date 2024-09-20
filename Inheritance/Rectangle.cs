namespace console_app
{
    class Rectangle : Shape
    {
        public Rectangle(double lenght, double breadth) : base(lenght,breadth) {
        }

        public void Display(){
            base.ShapeName("Rectangle");
            Console.WriteLine("Result : " + (lenght * breadth));
        }
    }
}