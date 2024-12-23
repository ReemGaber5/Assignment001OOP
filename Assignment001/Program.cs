using System;
using System.Drawing;

namespace Assignment001
{
    #region Question01
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}
    #endregion

    #region Question2

    //struct Person
    //{
    //    public string name;
    //    public int age;

    //    public Person(string Name,int Age)
    //    {
    //        name= Name;
    //        age= Age;

    //    }
    //}
    #endregion

    #region Quesion3
    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter,
    //}

    #endregion

    #region Question4


    #endregion

    #region Question5
    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}
    #endregion

    #region Question6
    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }
    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}
    #endregion

    #region Question7
    struct Person
    {
        public string name;
        public int age;

        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;

        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Console.WriteLine("Days of the week : ");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Question2
            //Person[] p = new Person[3];
            //p[0]= new Person("Ali",24);
            //p[1] = new Person("Ahmed", 26);
            //p[2] = new Person("Sara", 30);

            //Console.WriteLine(" The details of all the persons :");
            //foreach(Person person in p )
            //{
            //    Console.WriteLine($" Name: {person.name}, Age: {person.age}");
            //}

            #endregion

            #region Question3
            //Console.WriteLine("Enter Season Name :");

            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season selectedSeason))
            //{
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine(" Spring: March , April , May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine(" Summer: June , July, August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine(" Autumn: September , October, November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine(" Winter: December , January , February");
            //            break;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season Name ");
            //}

            #endregion

            #region Question5

            //Console.WriteLine("Enter Color :");

            //string color = Console.ReadLine();

            //if(Enum.TryParse(color,true,out Colors selectedcolor))
            //{
            //    Console.WriteLine($"{selectedcolor} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is not a primary color.");
            //}


            #endregion


            #region Question6

            //Console.WriteLine("Enter X1 for Point 1:");
            //double x1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Y1 for Point 1:");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter X2 for Point 2:");
            //double x2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Y2 for Point 2:");
            //double y2 = double.Parse(Console.ReadLine());


            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = CalculateDistance(point1, point2);
            //Console.WriteLine($"The distance is: {distance:F2}");
            #endregion

            #region Question7
            Person[] p = new Person[3];
            p[0] = new Person("Ali", 24);
            p[1] = new Person("Ahmed", 36);
            p[2] = new Person("Sara", 30);

            Person person = p.OrderByDescending(x => x.age).FirstOrDefault();
            Console.WriteLine($"The oldest one is: Name: {person.name}, Age: {person.age}");




            #endregion

        }
        static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

    }
}