using Task.Classes;

Circle circle1 = new Circle(1, 0, 1);
Circle circle2 = new Circle(3, 0, 3);
System.Console.WriteLine(circle1.GetCenterXY()[0] + " " + circle1.GetCenterXY()[1]);
System.Console.WriteLine(circle2.GetCenterXY()[0] + " " + circle2.GetCenterXY()[1]);
System.Console.WriteLine(circle2.GetRadius());
System.Console.WriteLine(circle2.ToString());