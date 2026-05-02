using Task_6_3DPoint_;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Point3D point1 = new Point3D(1.0, 2.0, 3.0);
Point3D point2 = new Point3D(4.0, 5.0, 6.0);
Point3D result = point1 + point2;
Console.WriteLine($"Результат додавання точок: A{point1} + B{point2} = C{result}");