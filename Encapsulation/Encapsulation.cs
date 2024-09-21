namespace console_app
{
     class Encapsulation
    {
        private string name;

        public string Name{
            get{ return name; }
            set{ name = value; }
        }

        public void Display(){
            Console.WriteLine("Encapsulation :" + name);
        }

        
    }
}