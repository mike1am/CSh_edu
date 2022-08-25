int FindBiggerDig (int num) {
    int ed = num % 10;
    int dec = num / 10;
    
    int result;
     
    if (ed > dec) result = ed;
    else result = dec;

    return result;
}

int ExclMidDig (int num) {
    int cen = num / 100;
    int ed = num % 10;
    return cen * 10 + ed;
}

void Ostat (int num1, int num2) {
    int ost = num1 % num2;
    if (ost == 0) Console.WriteLine("Второе число кратно первому");
    else Console.WriteLine($"Остаток от деления: {ost}");
}

int number1 = new Random().Next(0, 100);
int number2 = new Random().Next(0, 10);

Console.WriteLine($"Числа: {number1}, {number2}");
Ostat(number1, number2);

