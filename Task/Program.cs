using Task.Classes;

Point point = new Point(0, 0);
Circle circle1 = new Circle(point, 1);
Circle circle2 = new Circle(3, 0, 3);
System.Console.WriteLine(circle1.GetCenterXY()[0] + " " + circle1.GetCenterXY()[1]);
System.Console.WriteLine(circle2.GetCenterXY()[0] + " " + circle2.GetCenterXY()[1]);
System.Console.WriteLine(circle2.GetRadius());
System.Console.WriteLine(circle2.ToString());
System.Console.WriteLine(circle1.Distance(circle2));