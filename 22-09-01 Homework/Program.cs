// Aux methods =============

void PrintArr (int [] a) { // prints the integer array
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.Write($"{a[i]} ");
   }
   Console.WriteLine("");
}

int [] CreateRandArray (int size, int minVal, int maxVal) { // creates an array of integer values
   int [] a = new int [size];
   
   for (int i = 0; i < size; i++) {
      
      a[i] = new Random().Next(minVal, maxVal);
   }
   return a;
}

double [] CreateRandDblArr (int size, double minVal, double maxVal) {
   double [] a = new double [size];

   double factor = maxVal - minVal;

   for (int i = 0; i < size; i++)
      a[i] = new Random().NextDouble() * factor + minVal;
   
   return a;   
}

void PrintDblArr (double [] a) {
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.WriteLine($"{a[i]} ");
   }
}

// Task methods =============

int EvenNum (int [] a) { // returns the number of even elements
   int res = 0;

   for (int i = 0; i < a.Length; i++)
      if (a[i] % 2 == 0) res++;
   
   return res;
}

int OddElSum (int [] a) {
   int res = 0;
   for (int i = 1; i < a.Length; i += 2)
      res += a[i];
   
   return res;
}

double MinDblVal (double [] a) {
   double res = a[0];
   if (a.Length < 2) return res;

   for (int i = 1; i < a.Length; i++)
      if (a[i] < res) res = a[i];

   return res;
}

double MaxDblVal (double [] a) {
   double res = a[0];
   if (a.Length < 2) return res;

   for (int i = 1; i < a.Length; i++)
      if (a[i] > res) res = a[i];

   return res;
}

Console.Clear();
Console.Write("Please enter the task number {34, 36, 38}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());
// entering numbers and arrays for tasks
int num;
int size; // size of the array
int [] arr;

switch (taskNum) {
   case 34: {
      Console.Write("Please enter the size of the array: ");
      num = Convert.ToInt32(Console.ReadLine());
      
      arr = CreateRandArray(num, 100, 999);
      Console.WriteLine("Generated array:");
      PrintArr(arr);

      Console.WriteLine($"The number is odd elements is {EvenNum(arr)}");
      break;
   }

   case 36: {
      Console.Write("Please enter the size of the array: ");
      size = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter min scope: ");
      int min = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter max scope: ");
      int max = Convert.ToInt32(Console.ReadLine());   
 
      arr = CreateRandArray(size, min, max);
      Console.WriteLine("Generated array:");
      PrintArr(arr);

      Console.WriteLine($"The sum of the elements at odd positions: {OddElSum(arr)}");
      break;
   }

   case 38: {
      Console.Write("Please enter the size of the array: ");
      size = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter min scope: ");
      double minDbl = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter max scope: ");
      double maxDbl = Convert.ToDouble(Console.ReadLine());   
      
      double [] dblArr = CreateRandDblArr(size, minDbl, maxDbl);
      Console.WriteLine("Generated array:");
      PrintDblArr(dblArr);

      minDbl = MinDblVal(dblArr);
      maxDbl = MaxDblVal(dblArr);
      Console.WriteLine(minDbl);
      Console.WriteLine(maxDbl);
      Console.WriteLine($"The difference between min and max values is {maxDbl - minDbl}");
      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}