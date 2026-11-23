// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber <= totalLessons) {
//     Console.WriteLine($"Пара {totalLessons}");
//     totalLessons--;
// }

// Console.WriteLine("Пары закончились");

// Console.WriteLine();
// Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());
// int sum = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята {grade}");
//     grade = int.Parse(Console.ReadLine());
//     sum++;
// }

// Console.WriteLine($"Количество оценок: {sum}");
// Console.WriteLine("Ввод завершен");

using System.Diagnostics;

int sum = 0;
int count = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1");
int grade = int.Parse(Console.ReadLine());
int max = 0;

while (grade != -1)
{
    if (max <= grade)
    {
        max = grade;
    }
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine());
}

if (count > 0)
{
    Console.WriteLine($"Средний балл {(double)sum / count}");
    Console.WriteLine($"Наибольшая оценка: {max}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}

Console.WriteLine();
string correctPassword = "qwerty123";
int sum = 0;

while (true)
{
    Console.WriteLine("Введите пароль от личного кабинета");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        Console.WriteLine($"Количество неверных попыток: {sum}");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
    sum++;
}



