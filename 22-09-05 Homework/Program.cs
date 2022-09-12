// Aux methods =============

void PrintArray (int [] a) { // prints the integer array
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.Write($"{a[i]} ");
   }
   Console.WriteLine("");
}

int [] EnterArray() {
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

void PrintDblArray (double [] a) {
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.WriteLine($"{a[i]} ");
   }
}

// Task methods =============

int NumOfPositiveElements (int [] array) {
   int res = 0;
   
   for (int i = 0; i < array.Length; i++)
      if (array[i] > 0) res++;
   
   return res;
}

double [] CrossPoint (double k1, double b1, double k2, double b2) {
   double [] cross = new double [2];
   if (k1 == k2) {
      Console.WriteLine("The crosspoint is not exist!");
      return cross;
   }

   cross[0] = (b2 - b1) / (k1 - k2);
   cross[1] = cross[0] * k1 + b1;

   return cross;
}

Console.Clear();
Console.Write("Please enter the task number {41, 43}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());

switch (taskNum) {
   case 41: {
      int [] arr = EnterArray();
      Console.WriteLine("The entered array:");
      PrintArray(arr);

      Console.WriteLine($"The number of positive elements is {NumOfPositiveElements(arr)}");
      break;
   }

   case 43: {
      Console.Write("Please enter the gradient 1: ");
      double grad1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the offset 1: ");
      double offset1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the gradient 2: ");
      double grad2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the offset 2: ");
      double offset2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"The coordinates of crossing are:");
      PrintDblArray(CrossPoint(grad1, offset1, grad2, offset2)); 

      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}