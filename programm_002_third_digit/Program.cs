//Программа, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.

//задаем случайное число
Random rnd = new Random();
int Number = rnd.Next(1,65536);

Console.Write($"Случайное число - {Number}. ");

// определяем первые три цифры пятизначного числа
int first_digit = Number / 10000;
int second_digit = (Number - first_digit * 10000) / 1000;
int third_digit = (Number - first_digit * 10000 - 1000 * second_digit) / 100;

// проверяем условие если первые три цифры - 0, значит число двух значное. в противном случае выводим значение переменной третьей цифры числа
if ((first_digit == 0) & (second_digit == 0) & (third_digit == 0)) Console.WriteLine("Третьей цифры нет");
else
{
    Console.WriteLine($"Третья цифра - {third_digit}");
}