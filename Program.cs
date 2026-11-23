int lessonNumber = 1;
int totalLessons = 5;

while (lessonNumber <= totalLessons) {
    Console.WriteLine($"Пара {totalLessons}");
    totalLessons--;
}

Console.WriteLine("Пары закончились");

Console.WriteLine();
Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
int grade = int.Parse(Console.ReadLine());
int sum = 0;

while (grade != -1)
{
    Console.WriteLine($"Оценка принята {grade}");
    grade = int.Parse(Console.ReadLine());
    sum++;
}

Console.WriteLine($"Количество оценок: {sum}");
Console.WriteLine("Ввод завершен");

