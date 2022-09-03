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

void PrintArr (int [] a) {
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.Write($"{a[i]}, ");
   }
   Console.WriteLine("\b\b");
}

int DegreeOf (int num, int exp) { // calculates only positive values of the degree
   if (exp < 0) return -1;
   if (exp == 0) return 1;
   for (int i = 1; i < exp; i++) num *= num;
   return num;
}

int DigSum (int num) { // returns the sum of digits
   int res = 0;
   int len = FindDigNum(num);

   for (int i = 0; i < len; i++)
      res += DigAtPos(num, i);
   
   return res;
}

int [] EnterArr() {
   Console.Write("Please enter the size of the array: ");
   int size = Convert.ToInt32(Console.ReadLine());
   
   Console.WriteLine("Please enter the element values: ");
   int [] arr = new int [size];
   for (int i = 0; i < size; i++) {
      Console.Write($"Element {i}: ");
      arr[i] = Convert.ToInt32(Console.ReadLine());
   }
   
   return arr;
}

Console.Clear();
Console.Write("Please enter the task number {25, 27, 29}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());
int num; // entering number for tasks

switch (taskNum) {
   case 25: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter a degree: ");
      int deg = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine($"The exponential number is {DegreeOf(num, deg)}");
      break;
   }

   case 27: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"The sum of digits: {DigSum(num)}");
      break;
   }

   case 29: {
      int [] arr = EnterArr();
      Console.WriteLine("The entered array:");
      PrintArr(arr);
      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}