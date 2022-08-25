void compairNums (int num1, int num2) {
   if (num1 == num2) {
      Console.WriteLine("The numbers are equal");
      return;
   }
   int minNum, maxNum;
   if (num1 > num2) {
      maxNum = num1;
      minNum = num2;
   }
   else {
      maxNum = num2;
      minNum = num1;
   }
   Console.WriteLine($"The bigger number is {maxNum}, the smaller number is {minNum}");
}

void maxOfThree (int num1, int num2, int num3) {
   int maxNum = num1;
   if (num2 > maxNum) maxNum = num2;
   if (num3 > maxNum) maxNum = num3;
   Console.WriteLine($"The maximal number of three numbers is {maxNum}");
}

void outAllEven (int num) {
   int i = 0;

   while (i <= num) {
      Console.Write($"{i} ");
      i += 2;
   }
}

Console.Write("Please enter the task number {2, 4, 6, 8}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());

int num1, num2, num3;   // for tasks 3, 4
int num;                // for tasks 6, 8

switch (taskNum) {
   case 2: {
      Console.Write("Please enter first number: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter second number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      
      compairNums(num1, num2);
      break;
   }

   case 4: {
      Console.Write("Please enter first number: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter second number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter third number: ");
      num3 = Convert.ToInt32(Console.ReadLine());

      maxOfThree(num1, num2, num3);
      break;
   }

   case 6: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());
      
      if (!Convert.ToBoolean(num % 2)) Console.WriteLine ("The entered number is even. Congrats!");
      else Console.WriteLine ("The entered number is odd(((");
      break;
   }

   case 8: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Even numbers in the scopes from 0 to the entered number:");
      outAllEven (num);
      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}
