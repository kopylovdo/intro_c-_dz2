//Программа, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.
Random rnd = new Random();

int Number = rnd.Next(100,1000);

Console.WriteLine($"Случайное число - {Number}");

int first_digit = Number / 100;


int second_digit = (Number - first_digit * 100) / 10;
Console.WriteLine($"Вторая цифра случайного числа - {second_digit}");

