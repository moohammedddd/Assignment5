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

            #region ThirdProject
            Duration d1 = new Duration(1, 2, 3);
            Console.WriteLine(d1);
            Duration d2 = new Duration(330);
            Console.WriteLine(d2);
            #region D3=D1+D2
            Console.WriteLine("after adding");
            Duration d3 = d1 + d2;
            Console.WriteLine(d3);
            #endregion

            #region D3=D1 + 7800
            Console.WriteLine("after adding secound");
            Duration d4 = d1 + 7800;
            Console.WriteLine(d4.ToString());
            #endregion

            #region D3=666+D3
            Duration d5 = 666 + d3;
            Console.WriteLine(d5);
            #endregion

            #region D3= ++D1 (Increase One Minute)
            Duration d6 = ++d1;
            Console.WriteLine(d6);


            #endregion

            #region D3 = --D2 (Decrease One Minute)
            Duration d7 = --d6;
            Console.WriteLine(d7);
            #endregion

            #region D1= D1 -D2
            Duration d8 = d1 - d2;
            Console.WriteLine(d8);
            #endregion

            #region If (D1>D2)
            if (d1 > d2)
            {
                Console.WriteLine("d2 > d1");
            }
            else
            {
                Console.WriteLine("d1 < d2");
            }
            #endregion

            #region If (D1<=D2)
            if (d1 <= d2)
            {
                Console.WriteLine("d1 <= d2");
            }
            else
            {
                Console.WriteLine("d1 >= d2");
            }
            #endregion

            #region If (D1)
            if (d2)
                Console.WriteLine("d2 is true");
            #endregion

            #region DateTime Obj = (DateTime) D1
            DateTime obj = (DateTime)d1;
            Console.WriteLine(obj);
            #endregion

            #endregion
        }
    }
}
  