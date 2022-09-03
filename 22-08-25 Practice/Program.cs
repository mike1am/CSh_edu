int FindQuadrant(double x, double y) {
   if (x > 0 && y > 0) return 1;
   if (x < 0 && y > 0) return 2;
   if (x < 0 && y < 0) return 3;
   if (x > 0 && y < 0) return 4;
   return 0;
}

void Scopes (int quad) {
   if (quad == 1) Console.WriteLine("X & Y are positive");
   else if (quad == 2) Console.WriteLine("X is positive, Y is negative");
   else if (quad == 3) Console.WriteLine("X is negative, Y is negative");
   else if (quad == 4) Console.WriteLine("X is positive, Y is negative");
   else Console.WriteLine("Wrong input");

}

double calLen (double aX, double aY, double bX, double bY) {
   return Math.Sqrt(((bX - aX) * (bX - aX)) + ((bY - aY) * (bY - aY)));
}

Console.Clear();
Console.Write("X1: ");
double aX = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double aY = Convert.ToDouble(Console.ReadLine());
Console.Write("X2: ");
double bX = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double bY = Convert.ToDouble(Console.ReadLine());

/*
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
*/
double lenAB = calLen(aX, aY, bX, bY);
Console.WriteLine($"Distance A - B: {lenAB}");

//Scopes(quadrant);

//Console.WriteLine($"Quadrant: {quadrant}");
