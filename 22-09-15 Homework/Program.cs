// Task methods

void PrintNums (int n1, int n2) {
   Console.Write($"{n1} ");
   if (n1 != n2)
      if (n1 > n2) PrintNums(n1 - 1, n2);
      else PrintNums(n1 + 1, n2);
}

int SumOfNums (int n1, int n2) {
   if (n1 != n2)
      if (n1 > n2) return SumOfNums(n1 - 1, n2) + n1;
      else return SumOfNums(n1 + 1, n2) + n1;
   else return n2;
}

int Ackermann (int m, int n, bool log) {
   if (m > 0)
      if (n > 0) {
         if (log) Console.WriteLine($"Branch 1  m: {m}  n: {n}");
         int t = Ackermann(m, n - 1, log);
         if (log) Console.WriteLine($"Branch 2  m: {m}  n: {n}  t: {t}");
         return Ackermann(m - 1, t, log);
      }
      else {
         if (log) Console.WriteLine($"Branch 3  m: {m}  n: {n}");
         return Ackermann(m - 1, 1, log);
      }
   else {
      if (log) Console.WriteLine($"Branch 4  m: {m}  n: {n}");
      return n + 1;
   }
}
/*
int Foo (int i, int x) {
   if (i == 0) {
      Console.WriteLine($"Return {x + 1}");
      return x + 1;
   }
   int res = x;
   for (int k = 0; k < x + 2; k++) {
      Console.WriteLine($"x: {x}  k: {k}  i: {i}  res: {res}");
      res = Foo(i - 1, res);
   }
   return res;
}
*/
Console.Clear();
Console.Write("Please enter the task number {64, 66, 68}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());

switch (taskNum) {
   case 64: {
      Console.Write("Please enter the start number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the finish number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The result row:");
      PrintNums(num1, num2);
      
      break;
   }

   case 66: {
      Console.Write("Please enter the start number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the finish number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine($"The sum of the natural numbers between {num1} and {num2} is {SumOfNums(num1, num2)}");
      
      break;
   }

   case 68: {
      Console.Write("Please enter the first argument: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the second argument: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"The Ackermann function is {Ackermann(num1, num2, false)}");
      //Console.WriteLine($"Foo function is {Foo(num1, num2)}");

      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}