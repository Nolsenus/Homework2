bool IsWeekend (int num) {
    return num == 6 || num == 7;
}

Console.Write("Введите целое число: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.Write(input + " -> ");
if (IsWeekend(input)) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}