string MakeProgrammersString (int number) {
    string result = number + " программист";
    if (number % 10 >= 5 || (number % 100 >= 10 && number % 100 <= 14)) {
        result += "ов";
    } else if (number % 10 > 1) {
        result += "а";
    }
    return result;
}

Console.Write("Введите целое число: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(input + " -> " + MakeProgrammersString(input));