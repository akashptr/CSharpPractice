namespace Practice_Mosh.Advance.Delegates
{
    public delegate void MultipleMethods(int r);
    public class Circle
    {
        private const float PI = 3.14f;
        static void GetArea(int radius)
        {
            Console.WriteLine("The area is: " + PI * radius * radius);
        }
        static void GetPerimeter(int radius)
        {
            Console.WriteLine("The perimeter is: " + 2 * PI * radius);
        }
        static int GetDiameter(int radius)
        {
            return 2 * radius;
        }
        public static void Main(string[] args)
        {
            var inst = new MultipleMethods(GetPerimeter);
            inst += GetArea;
            inst(10);

            //Example of Func and Action
            var inst2 = new Action<int>(GetArea);
            var inst3 = new Func<int, int>(GetDiameter);

            inst2(20);
            Console.WriteLine("the diameter: " + inst3(20));
        }
    }
}
