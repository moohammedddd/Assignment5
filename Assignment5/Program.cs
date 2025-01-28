namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstProject
            Point3D P1 = new Point3D(10, 20, 30);
            Console.WriteLine(P1);
            Console.WriteLine("enter the x point");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y point");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the z point");
            int z1 = int.Parse(Console.ReadLine());
            Point3D P2 = new Point3D(x1, y1, z1);
            Console.WriteLine(P2);
            if (P2 == P1)
            {
                Console.WriteLine("The Two Point is Equal");
            }
            else
            {
                Console.WriteLine("The Two Point is Not Equal");
            }

            Point3D[] points =
            {
               new Point3D (10,20,30),
              new Point3D  (5,20,30),
              new Point3D  (16,30,50)
            };
            //Array.Sort(points);
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }


            #endregion

            #region SecoundProject
            int a = 40;
            int b = 20;
            Console.WriteLine($"{Math.Add(a, b)}");
            Console.WriteLine($"{Math.Sub(a, b)}");
            Console.WriteLine($"{Math.Mul(a, b)}");
            Console.WriteLine($"{Math.Div(a, b)}");
            #endregion

        }
    }
}
  