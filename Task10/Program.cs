int GetSecondDigit(int number) {
    return (number / 10) % 10;
}
Console.Write("Введите трёхзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(input + " -> " + GetSecondDigit(input));