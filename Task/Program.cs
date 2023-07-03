using Task.Classes;

Point point1 = new Point(4, 0);
Point point2 = new Point(4, 0);
// System.Console.WriteLine(point2.Distance(point1));
Circle circle1 = new Circle(point1, 4);
Circle circle2 = new Circle(7, 0, 3);
System.Console.WriteLine(circle1.GetCenterXY()[0] + " " + circle1.GetCenterXY()[1]);
System.Console.WriteLine(circle2.GetCenterXY()[0] + " " + circle2.GetCenterXY()[1]);
System.Console.WriteLine(circle1.ToString());
System.Console.WriteLine(circle2.ToString());
System.Console.WriteLine(circle2.GetCircumference());

System.Console.WriteLine(circle2.Distance(circle1));