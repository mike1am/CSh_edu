int FindDigNum (int num) {    // finding the number of sign. digits of the number
   int dig = 0;

   while (num > 0) {
      num /= 10;
      dig++;
   }

   return dig;
}

int DigAtPos (int num, int pos) {  // returns the digit at the position, beginning from least sign. digit, numbering from 0
   return num / (Convert.ToInt32(Math.Pow(10, pos))) % 10;
}

bool IsPalindrome (int num) {
   int digNum = FindDigNum(num);

   for (int i = 0; i < digNum / 2; i++)
      if (DigAtPos(num, i) != DigAtPos(num, digNum - i - 1)) return false;

   return true;
}

double DistAB_3D (double x1, double y1, double z1, double x2, double y2, double z2) {
   return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

void PrintCubeRow (int num) {
   for (int i = 1; i <= num; i++)
      Console.Write ($"{Math.Pow(i, 3)} ");
   Console.WriteLine();
}

Console.Clear();
Console.Write("Please enter the task number {19, 21, 23}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());
int num; // entering number for tasks

switch (taskNum) {
   case 19: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());
      
      if (IsPalindrome(num)) Console.WriteLine("The entered number is palindrome.");
      else Console.WriteLine("The entered number is not palindrome.");
      break;
   }

   case 21: {
      Console.WriteLine("Please enter the coordinates of point A");
      Console.Write("X: ");
      double aX = Convert.ToDouble(Console.ReadLine());
      Console.Write("Y: ");
      double aY = Convert.ToDouble(Console.ReadLine());
      Console.Write("Z: ");
      double aZ = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Please enter the coordinates of point B");
      Console.Write("X: ");
      double bX = Convert.ToDouble(Console.ReadLine());
      Console.Write("Y: ");
      double bY = Convert.ToDouble(Console.ReadLine());
      Console.Write("Z: ");
      double bZ = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine($"The distance between A and B: {DistAB_3D(aX, aY, aZ, bX, bY, bZ)}");
      break;
   }

   case 23: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());

      PrintCubeRow(num);
      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}

