// Aux methods =============

void PrintArray (int [] a) { // prints the integer array
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.Write($"{a[i]} ");
   }
   Console.WriteLine("");
}

int [,] CreateRandom2dArray (int rows, int columns, int minScope, int maxScope) {
   int [,] resArray = new int [rows, columns];
   
   for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
         resArray[i,j] = new Random().Next(minScope, maxScope + 1);

   return resArray;
}

int [,] CreateUser2dArray () {
      Console.Write("Please enter the number of rows: ");
      int rows = Convert.ToInt32(Console.ReadLine());

      Console.Write("Please enter the number of columns: ");
      int columns = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter min scope: ");
      int min = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter max scope: ");
      int max = Convert.ToInt32(Console.ReadLine());   
 
      int [,] array = CreateRandom2dArray(rows, columns, min, max);
      Console.WriteLine("Generated array:");
      Print2dArray(array);
      Console.WriteLine();
      
      return array;
}

/*
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
*/
void PrintDblArray (double [] a) {
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.WriteLine($"{a[i]} ");
   }
}

void Print2dDblArray (double [,] array) {
   for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write($"{array[i,j]} ");
      
      Console.WriteLine();
   }
}

void Print2dArray (int [,] array) {
   for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write($"{array[i,j]} ");
      
      Console.WriteLine();
   }
}

// Task methods =============

double [,] CreateRandom2dDblArray (int rows, int columns, double minScope, double  maxScope) {
   double [,] resArray = new double [rows, columns];
   
   double factor = maxScope - minScope;
   
   for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
         resArray[i,j] = new Random().NextDouble() * factor + minScope;

   return resArray;
}

bool isExist (int [,] array, int row, int column) {
   return
      row >=0 && 
      column >=0 &&
      row < array.GetLength(0) &&
      column < array.GetLength(1);
}

double [] meanPerColumns (int [,] array) {
   double [] meanValues = new double [array.GetLength(1)];

   for (int j = 0; j < array.GetLength(1); j++) {
      int columnSum = 0;
    
      for (int i = 0; i < array.GetLength(0); i++)
         columnSum += array[i,j];
    
      meanValues[j] = Convert.ToDouble(columnSum) / array.GetLength(0);
   }

   return meanValues;
}

Console.Clear();
Console.Write("Please enter the task number {47, 50, 52}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());

switch (taskNum) {
   case 47: {
      Console.Write("Please enter the number of rows: ");
      int numRows = Convert.ToInt32(Console.ReadLine());

      Console.Write("Please enter the number of columns: ");
      int numColumns = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter min scope: ");
      double min = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter max scope: ");
      double max = Convert.ToInt32(Console.ReadLine());   
 
      double [,] arr = CreateRandom2dDblArray(numRows, numColumns, min, max);
      Console.WriteLine("Generated array:");
      Print2dDblArray(arr);
      
      break;
   }

   case 50: {
      int [,] arr = CreateUser2dArray();

      Console.Write("Please enter a row: ");
      int row = Convert.ToInt32(Console.ReadLine());

      Console.Write("Please enter a column: ");
      int column = Convert.ToInt32(Console.ReadLine());

      if (isExist(arr, row, column))
         Console.WriteLine($"The element at row {row} and column {column} contains {arr[row,column]}");
      else
         Console.WriteLine($"The element at row {row} and column {column} is not exists at the array");

      break;
   }

   case 52: {
      int [,] arr = CreateUser2dArray();
 
      Console.WriteLine("Mean values of columns :");
      PrintDblArray(meanPerColumns(arr));

      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}