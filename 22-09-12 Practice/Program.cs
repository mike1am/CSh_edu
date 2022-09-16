void PrintArray (int [] a) { // prints the integer array
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.Write($"{a[i]} ");
   }
   Console.WriteLine("");
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

int [,] CreateRandom2dArray (int rows, int columns, int minScope, int maxScope) {
   int [,] resArray = new int [rows, columns];
   
   for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
         resArray[i,j] = new Random().Next(minScope, maxScope + 1);

   return resArray;
}

void Print2dArray (int [,] array) {
   for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write($"{array[i,j]} ");
      
      Console.WriteLine();
   }
}

int [,] MatrixTranspone (int [,] array) {
   int [,] resArray = new int [array.GetLength(1),array.GetLength(0)];

   for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
         resArray[j,i] = array[i,j];

   return resArray;
}

int [] findMinElementMaxrix (int [,] array) {
   int minValue = array [0,0];
   int [] minIndex = {0, 0};
   
   for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
         if (array[i,j] < minValue) {
            minValue = array[i,j];
            minIndex[0] = i;
            minIndex[1] = j;
         }
   
   return minIndex;
}

int [,] DelRowAndColumn (int [,] array, int row, int column) {
   int [,] resArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
   
   for (int i = 0; i < array.GetLength(0); i++) {
      int i1 = i;
      if (i > row) i1--;
      for (int j = 0; j < array.GetLength(1); j++) {
         int j1 = j;
         if (j > column) j1--;
         if (i != row && j != column)
            resArray[i1,j1] = array[i,j];
      }
   }
   return resArray;
}

int [,] origArr = CreateUser2dArray();

//int [,] transpArray = MatrixTranspone(origArr);

//Print2dArray(transpArray);

int [] minEl = findMinElementMaxrix(origArr);
PrintArray(minEl);

int [,] newArray = DelRowAndColumn(origArr, minEl[0], minEl [1]);

Print2dArray(newArray);
