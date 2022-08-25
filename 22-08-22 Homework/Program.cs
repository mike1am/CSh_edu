int secDig (int num) {
   return num / 10 % 10;
}

int thirdDig (int num) {
   if (num < 100) return -1; // третья цифра отсутствует

   int divider = 1;   // делитель для определения остатка и искомой цифры
   int num1 = 0;      // временное число для определения кол. значащих разрядов в изначальном числе
   int piece;         // перемещаемая часть из num в num1
   while (num1 < num) {
      divider *= 10;
      piece = num % divider;
      num1 += piece;
      num -= piece;
   }
   divider /= 1000;  // возврат к третьей цифре
   return num1 / divider % 10; // % 10 для очищения от старших разрядов
}

bool isWeekend (int dayNum) {
   return ((dayNum == 6) || (dayNum == 7));
}

Console.Write("Please enter the task number {10, 13, 15}: ");
int taskNum = Convert.ToInt32(Console.ReadLine());
int num; // entering number for tasks

switch (taskNum) {
   case 10: {
      Console.Write("Please enter a three-digit number: ");
      num = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine($"The second digit is {secDig(num)}");
      break;
   }

   case 13: {
      Console.Write("Please enter a number: ");
      num = Convert.ToInt32(Console.ReadLine());
      
      int dig = thirdDig(num);
      if (dig != -1) Console.WriteLine($"The third digit is {dig}");
      else Console.WriteLine("The third digit is absent");
      break;
   }

   case 15: {
      Console.Write("Please enter a number of a weekday: ");
      num = Convert.ToInt32(Console.ReadLine());

      if (isWeekend(num)) Console.WriteLine("The entered day is a weekend day");
      else Console.WriteLine("The entered day is not a weekend day");
      break;
   }

   default: {
      Console.Write("You entered wrong task number!");
      break;
   }   
}
