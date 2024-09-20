namespace console_app
{
    class Shape
    {
        protected double lenght;
        protected double breadth;

        public Shape(double lenght, double breadth){
            this.lenght=lenght;
            this.breadth=breadth;   
        }

        public void ShapeName(string name){
            Console.WriteLine(name + " :");
        }
    }
}