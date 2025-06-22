using System;

namespace assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Syntax Error : the code violate the syntax rules of the C#
            //1-
            // int x
            //2-
            // int x;
            //x = 5;
            //y = 1;

            //RunTime Error : happen during the excution of the program
            //int x, y;
            //x = 5;
            //y = 0;
            //Console.WriteLine(x/y);

            //Logical Error : caused by incorrect algorithm or incorrect data

            //File I/O Error : trying to write a read only file and trying to access file that doesnt exist

            #endregion

            #region
            //variable declaration 
            //int x = 3;

            //int y;
            //y= 5;
            #endregion

            #region  
            // CTS --> Common Type System
            //1- Value Type --> primitive type like float , int char
            //2- Reference Type --> non-primitive type like class , interface , delegate and array
            #endregion
            #region
            //Data Type 
            //    1- Struct

            //Byte -->  1 Byte
            //Short --> 2 Byte
            //int -->  4 Byte
            //Long -->  8 Byte

            //Float -->  4 Byte
            //Decimal --> 16 Byte
            //Double -->  8 Byte

            //Char -->  2 Byte
            //Bool -->  1 Byte
            //DateTime --> 8 Byte

            //   2- Class
            // Object , String , Delegate and array

            // 
            #endregion
            #region
            //      Value Type
            //int x;
            //x = 4;
            //Int32 y = 9;
            //y = x; //4
            //x++; //5
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion
            #region
            //    Reference Data Type
            //Point p1;

            //p1 = new Point();

            //Point p2 = new Point();

            //p1.x = 1;
            //p1.y = 2;

            //p2.x = 3;
            //p2.y = 4;

            //Console.WriteLine($"P1 ==>  ({p1.x},{p1.y})");
            //Console.WriteLine($"P2 ==>  ({p2.x},{p2.y})");

            //p2 = p1;

            //p1.x = 7;
            //p1.y = 8;

            //Console.WriteLine($"P1 ==>  ({p1.x},{p1.y})");
            //Console.WriteLine($"P2 ==>  ({p2.x},{p2.y})");

            #endregion
            #region
            Point3D p3D = new Point3D();
            p3D.x = 1;
            p3D.y = 2;
            p3D.z = 3;


            //object

            //Point p1;
            //p1 = new Point3D();
            //p1 = new Point3D();

            //object obj;
            //obj = new object();
            //obj = new Point3D();
            //obj = new temp();
            //obj = 123;
            //obj = 5.3;
            //obj = 'e';
            //obj = "karim saleh";


            //Print(2, 3);
            //Print(2.3, 4.9);
            //Print('k', 'a');

            //static void Print(int x , int y)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);

            //}
            //static void Print(double x, double y)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);

            //}
            //static void Print(char x, char y)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);
            //}

            // 

            //Print(2, 3);
            //Print(2.3, 4.9);
            //Print('k', 'a');

            //static void Print<k>(k x, k y)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);

            //}

            //Point p1;
            //p1 = new Point3D();
            //p1 = new Point3D();

            //object obj;
            //obj = new object();
            //obj = new Point3D();
            //obj = new temp();
            //obj = 123;
            //obj = 5.3;
            //obj = 'e';
            //obj = "karim saleh";

            //int x=1, y=2;
            //int sum;
            //String s = "karim saleh";
            
            //sum = x+y;
            //sum = x + y + (int)s; 
            //sum = x + y + (int)obj; 
            //Console.WriteLine(sum);//6
           // sum = x+y+s; // Error 



            #endregion
            Console.WriteLine("Hello World!");
        }
    }
}
