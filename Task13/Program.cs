int GetThirdDigit (int number) {
    if (number < 100 && number > -100) {
        return -1;
    }
    if (number < 0) {
        number = -number;
    }
    int third = number % 10;
    while (number / 1000 > 0) {
        number /= 10;
        third = number % 10;
    }
    return third;
}

Console.Write("Введите целое число: ");
int input = Convert.ToInt32(Console.ReadLine());
int third = GetThirdDigit(input);
Console.Write(input + " -> ");
if (third == -1) {
    Console.WriteLine("Третьей цифры нет");
} else {
    Console.WriteLine(third);
}