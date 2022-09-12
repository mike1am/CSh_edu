int[] ReverseArray (int[] arr) {
   int[] resArr = new int [arr.Length];

   for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
      resArr[i] = arr[j];
   
   return resArr;
}

void PrintArr (int [] a) { // prints the integer array
   for (int i = 0; i < a.Length; i++)
      Console.Write($"{a[i]} ");
   
   Console.WriteLine("");
}

int [] CreateRandArray (int size, int minVal, int maxVal) { // creates an array of integer values
   int [] a = new int [size];
   
   for (int i = 0; i < size; i++)
      a[i] = new Random().Next(minVal, maxVal);
   
   return a;
}

string BinStr (int num) {
   string bin = string.Empty;

   while (num > 0) {
      bin = num % 2 + bin;
      num /= 2;
   }

   return bin;
}

int [] Fibonacci (int len, int el1, int el2) {
   int [] res = new int [len];
   res[0] = el1;
   res[1] = el2;

   for (int i = 2; i < len; i++)
      res[i] = res[i - 1] + res[i - 2];

   return res;
}

bool IsTriangle (int len1, int len2, int len3) {
   if (len1 > len2 + len3) return false;
   if (len2 > len1 + len3) return false;
   if (len3 > len2 + len1) return false;
   return true;
}


Console.Write("Please enter the size of Fibonacci series: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("First element: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Second element: ");
int num2 = Convert.ToInt32(Console.ReadLine());   

int[] fibArray = Fibonacci(size, num1, num2);
PrintArr(fibArray);
PrintArr(ReverseArray(fibArray));

Console.Write("Please enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Binary view: {BinStr(num)}");
