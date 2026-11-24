// // int lessonNumber = 1;
// // int totalLessons = 5;

// // while (lessonNumber <= totalLessons) {
// //     Console.WriteLine($"Пара {totalLessons}");
// //     totalLessons--;
// // }

// // Console.WriteLine("Пары закончились");

// // Console.WriteLine();
// // Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
// // int grade = int.Parse(Console.ReadLine());
// // int sum = 0;

// // while (grade != -1)
// // {
// //     Console.WriteLine($"Оценка принята {grade}");
// //     grade = int.Parse(Console.ReadLine());
// //     sum++;
// // }

// // Console.WriteLine($"Количество оценок: {sum}");
// // Console.WriteLine("Ввод завершен");

// using System.Diagnostics;

// int sum = 0;
// int count = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());
// int max = 0;

// while (grade != -1)
// {
//     if (max <= grade)
//     {
//         max = grade;
//     }
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

// Console.WriteLine();
// string correctPassword = "qwerty123";
// int sum = 0;

// while (true)
// {
//     Console.WriteLine("Введите пароль от личного кабинета");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешен");
//         Console.WriteLine($"Количество неверных попыток: {sum}");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова");
//     sum++;
// }

string answer;

do
{
    Console.WriteLine("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.WriteLine("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();

} while (answer == "да");

Console.WriteLine("Дневник сохранён");

// Вариант А
Console.WriteLine();
int N = 8;
int count = 1;

while (count < 11)
{
    Console.WriteLine($"{N} * {count} = {N * count}");
    count++;
}

// Вариант Б
Console.WriteLine();
Console.WriteLine("Введите имя ученика, для завершения введите конец");
string word = Console.ReadLine();
int sum = 0;

while (word != "конец")
{
    Console.Write($"Введите имя ученика: ");
    word = Console.ReadLine();
    sum++;
}

Console.WriteLine($"Имен учеников: {sum}");

// // Распределитель вариантов
// Console.WriteLine();
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Вариант 5
Console.WriteLine();
string correctPassword = "halo";
string password;

while (true)
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Дверь открыта");
        break;
    }
    else
    {
        Console.WriteLine("Пароль неверный, попробуйте еще раз");
    }
}

// Вариант 6
Console.WriteLine();
Console.WriteLine("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());
int count = 0;

while (number != 0)
{
    number /= 10;
    count++;
}

Console.WriteLine($"Цифр в числе: {count}");