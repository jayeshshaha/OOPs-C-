namespace console_app
{
    class Triangle : Shape
    {
        public Triangle(double lenght, double breadth) : base(lenght,breadth) {
        }

        public void Display(){
            base.ShapeName("Triangle");
            Console.WriteLine("Result : " + (0.5 + (lenght * breadth)));
        }

    }
}