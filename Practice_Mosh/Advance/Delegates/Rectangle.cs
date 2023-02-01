namespace Practice_Mosh.Advance.Delegates
{
    public delegate void InstanceMethodDelegate();
    public delegate void StaticMethodDelegate(double h, double w);
    public class Rectangle
    {
        private double _height;
        private double _width;
        public Rectangle(double h, double w)
        {
            _height = h;
            _width = w;
        }
        public void GetArea()
        {
            Console.WriteLine("The area is: " + _height * _width);
        }
        public static void GetPerimeter(double height, double width)
        {
            Console.WriteLine("The perimeter is: " + 2 * (height + width));
        }
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12.2, 10.5);
            InstanceMethodDelegate delegateInstance = new InstanceMethodDelegate(rectangle.GetArea);
            delegateInstance.Invoke();
            //StaticMethodDelegate delInst = new StaticMethodDelegate(Rectange.GetPerimeter);
            StaticMethodDelegate delInst = GetPerimeter;
            delInst(10, 20);
        }
    }
}
