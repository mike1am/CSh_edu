int [] CreateRandArray(int n, int minVal, int maxVal) {
   int [] a = new int [n];

   for (int i = 0; i < n; i++) {
      a[i] = new Random().Next(minVal, maxVal);
   }
   return a;
}

void PrintArr (int [] a) {
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      Console.Write($"{a[i]} ");
   }
   Console.WriteLine();
}

int NegativeSum (int [] a) {
   int len = a.Length;
   int res = 0;
   for (int i = 0; i < len; i++) {
      if (a[i] < 0) res += a[i];
   }
   return res;
}

int [] NegArr (int [] a) {
   int len = a.Length;
   int [] resArr = new int [a.Length];
   for (int i = 0; i < len; i++) {
      resArr[i] = a[i] * (-1);
   }
   return resArr;
}

bool WasFound (int [] a, int num) {
   int len = a.Length;
   for (int i = 0; i < len; i++) {
      if (a[i] == num) return true;
   }
   return false;
}

int NumTestEl (int [] a, int min, int max) {
   int count = 0;
   for (int i = 0; i < a.Length; i++) {
      if ((a[i] >= min) && (a[i] <= max))
         count++;
   }

   return count;
}

int [] MultiplPairs(int [] a) {
   int [] resArr = new int [(a.Length / 2) + (a.Length % 2)];
   for (int i = 0; i < (a.Length / 2) + (a.Length % 2); i++) {
      if (i < a.Length / 2) resArr[i] = a[i] * a[a.Length - i - 1];
      else resArr[i] = a[i];
   }
   return resArr;
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min scope: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max scope: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter inspected number: ");
int insNum = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandArray(size, min, max);

PrintArr(array);

Console.WriteLine($"Sum of negative members: {NegativeSum(array)}");

PrintArr(NegArr(array));

if (WasFound(array, insNum)) Console.WriteLine("The number is present");
else Console.WriteLine("The number is absense");

Console.Write("Enter min scope of monitoring range: ");
int minTest = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max scope of monitoring range: ");
int maxTest = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number of elements within monitoring range: {NumTestEl(array, minTest, maxTest)}");

Console.WriteLine("The array with multiplied pairs:");
PrintArr(MultiplPairs(array));