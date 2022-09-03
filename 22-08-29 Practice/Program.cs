int FindSum (int a) {
   int sum = 0;
   for (int i = 0; i <= a; i++) {
      sum += i;
   }

   return sum;
}

int FindDigNum (int num) {
   int dig = 0;
   while (num > 0) {
      num /= 10;
      dig++;
   }
   return dig;
}

int Fact (int num) {
   int f = 1;
   for (int i = 1; i <= num; i++)
      f *= i;
   return f;
}

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

//Console.WriteLine(BinArray(7));

PrintArr(CreateRandArray(7, 0, 5));