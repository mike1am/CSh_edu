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

int [,] Create2dArrayIndexSum (int rows, int columns) {
   int [,] resArray = new int [rows, columns];
   
   for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
         resArray[i,j] = i + j;

   return resArray;
}

void ChangeEvenEl2Square (int [,] array) {
   for (int i = 0; i < array.GetLength(0); i += 2)
      for (int j = 0; j < array.GetLength(1); j += 2)
         array[i,j] *= array[i,j];
}

int MainDiagonalSum (int [,] array) {
   int scope;
   int sum = 0;
   if (array.GetLength(0) > array.GetLength(1)) scope = array.GetLength(1);
   else scope = array.GetLength(0);

   for (int i = 0; i < scope; i++)
      sum += array[i,i];

   return sum;
}

Console.Write("Please enter the number of rows: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the number of columns: ");
int numColumns = Convert.ToInt32(Console.ReadLine());
/*
Console.Write("Please enter the minimal scope of values: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the maximal scope of values: ");
int max = Convert.ToInt32(Console.ReadLine());
*/
int [,] arr = Create2dArrayIndexSum(numRows, numColumns);
Print2dArray(arr);

ChangeEvenEl2Square(arr);

Console.WriteLine();
Print2dArray(arr);

Console.WriteLine($"The main diagonal sum is {MainDiagonalSum(arr)}");