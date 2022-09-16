void PrintNums (int m, int n) {
   Console.Write($"{m} ");
   if (m != n)
      if (m > n) PrintNums(m - 1, n);
      else PrintNums(m + 1, n);
   //Console.Write($"{m} ");
}

int SumOfDigits (int n) {
   if (n > 0)
      return SumOfDigits(n / 10) + n % 10;
   else return 0;
}

double PowNum (int n, int p) {
   if (p != 0) 
      if (p > 0) return PowNum(n, p - 1) * n;
      else return PowNum(n, p + 1) / n;
   else return 1.0;
}

PrintNums(9, -13);

//Console.WriteLine(PowNum(2, -3));

//Console.WriteLine(SumOfDigits(7843));