// Aux methods

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

// Task methods

void SortRowsToMin (int [,] array) {
   for (int i = 0; i < array.GetLength(0); i++) {
      ReplaceRow(array, i, OrderToMin(GetRow(array,i)));
   }
}

int [] GetRow (int [,] array, int row) {
   int [] res = new int [array.GetLength(1)];
   
   for (int i = 0; i < array.GetLength(1); i++)
      res[i] = array[row,i];

   return res;
}

int [] OrderToMin (int [] array) {
   int [] resArray = (int [])array.Clone();
   
   int changeCnt = 1;
   while (changeCnt > 0) {
      changeCnt = 0;
      for (int i = 0; i < resArray.Length - 1; i++) {
         if (resArray[i + 1] > resArray[i]) {
            changeCnt++;
            int tmp = resArray[i];
            resArray[i] = resArray[i + 1];
            resArray[i + 1] = tmp;
         }
      }
   }

   return resArray;
}

void ReplaceRow (int [,] array, int rowIndex, int [] row) {
   for (int i = 0; i < array.GetLength(1); i++)
      array[rowIndex,i] = row[i];
}

int FindMinRowSum (int [,] array) {
   int minSum = SumOfArray(GetRow(array, 0));
   int minRow = 0;

   for (int i = 1; i < array.GetLength(0); i++) {
      int sum = SumOfArray(GetRow(array, i));
      if (sum < minSum) {
         minSum = sum;
         minRow = i;
      }
   }

   return minRow;
}

int SumOfArray (int [] array) {
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
      sum += array[i];

   return sum;
}

bool IsMultipliable (int [,] matrix1, int [,] matrix2) {
   return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int [,] MultiplyMatrices (int [,] matrix1, int [,] matrix2) {
   int [,] resMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

   for (int i = 0; i < matrix1.GetLength(0); i++)
      for (int j = 0; j < matrix2.GetLength(1); j++) {
         resMatrix[i,j] = 0;
         for (int k = 0; k < matrix1.GetLength(1); k++)
            resMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
      }
   
   return resMatrix;
}

int [,,] CreateOrdered3dArray (int numLayers, int numRows, int numColumns) {
   int [,,] resArray = new int [numLayers, numRows, numColumns];

   int count = 0;
   for (int l = 0; l < numLayers; l++)
      for (int i = 0; i < numRows; i++)
         for (int j = 0; j < numColumns; j++) {
            resArray[l,i,j] = count;
            count++;
         }

   return resArray;
}

void Shake3dArray (int [,,] array) {
   for (int l = 0; l < array.GetLength(0); l++)
      for (int i = 0; i < array.GetLength(1); i++)
         for (int j = 0; j < array.GetLength(2); j++) {
            int l1 = new Random().Next(0, array.GetLength(0));
            int i1 = new Random().Next(0, array.GetLength(1));
            int j1 = new Random().Next(0, array.GetLength(2));
            
            int tmp = array[l,i,j];
            array[l,i,j] = array[l1,i1,j1];
            array[l1,i1,j1] = tmp;
         }
}

void Print3dArray (int [,,] array) {
   for (int l = 0; l < array.GetLength(0); l++) {
      Console.WriteLine($"Layer {l}");

      for (int i = 0; i < array.GetLength(1); i++) {
         for (int j = 0; j < array.GetLength(2); j++)
            Console.Write($"{array[l,i,j]} ");
      
         Console.WriteLine();
      }
      Console.WriteLine();
   }

}

void FillMatrixBySpiral (int [,] matrix) {
   for (int i = 0; i < matrix.GetLength(0); i++)
      for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i,j] = -1;
   
   FillMatrixRecNext(matrix, 0, 0, 0, 1, 0);
}

void FillMatrixRecNext(int [,] matrix, int row, int rowStep, int col, int colStep, int value) {
   if (row >=0 &&
       row < matrix.GetLength(0) &&
       col >= 0 &&
       col < matrix.GetLength(1) &&
       matrix[row, col] == -1) {
      
      matrix[row, col] = value;
      FillMatrixRecNext(matrix, row + rowStep, rowStep, col + colStep, colStep, value + 1);
      if (colStep == 1) {
         rowStep = 1;
         colStep = 0;
      }
      else if (rowStep == 1) {
         rowStep = 0;
         colStep = -1;
      }
      else if (colStep == -1) {
         rowStep = -1;
         colStep = 0;
      }
      else {
         rowStep = 0;
         colStep = 1;
      }
      FillMatrixRecNext(matrix, row + rowStep, rowStep, col + colStep, colStep, value + 1);
   }
}

Console.Clear();
Console.Write("Please enter the task number {54, 56, 58, 60, 62}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());

switch (taskNum) {
   case 54: {
      int [,] arr = CreateUser2dArray();

      SortRowsToMin(arr);
      
      Console.WriteLine("Sorted rows :");
      Print2dArray(arr);

      break;
   }

   case 56: {
      int [,] arr = CreateUser2dArray();
 
      Console.WriteLine($"The row index with the least sum is {FindMinRowSum(arr)}");

      break;
   }

   case 58: {
      Console.WriteLine("Matrix 1");
      int [,] matr1 = CreateUser2dArray();
      Console.WriteLine("Matrix 2");
      int [,] matr2 = CreateUser2dArray();

      if (IsMultipliable(matr1, matr2)) {
         Console.WriteLine("The result of multiplication:");
         Print2dArray(MultiplyMatrices(matr1, matr2));
      }
      else Console.WriteLine("The matrices cannot be multiplied");
 
      break;
   }

   case 60: {
      Console.Write("Please enter the number of layers: ");
      int layers = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the number of rows: ");
      int rows = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the number of columns: ");
      int columns = Convert.ToInt32(Console.ReadLine());

      int [,,] arr = CreateOrdered3dArray(layers, rows, columns);
      //Print3dArray(arr);
      Shake3dArray(arr);
      Print3dArray(arr);

      break;
   }

   case 62: {
      Console.Write("Please enter the number of rows: ");
      int rows = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the number of columns: ");
      int columns = Convert.ToInt32(Console.ReadLine());

      int [,] array  = new int [rows, columns];
      FillMatrixBySpiral(array);
      Print2dArray(array);
      
      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}