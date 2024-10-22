List<double> start = [];

Console.Write("Дана функция y(x)=cos(x^2)+sin^2(x). \nВведите начало отрезка а = ");
start.Add(Convert.ToDouble(Console.ReadLine()));

Console.Write("Введите конец отрезка b = ");
start.Add(Convert.ToDouble(Console.ReadLine()));

Console.Write("Введите шаг h = ");
start.Add(Convert.ToDouble(Console.ReadLine()));

List<double> answerX = [];
List<double> answerY = [];

int points = 0;
int intersections = 0;
double x = start[0];

while (x <= start[1]) 
{
    answerY.Add(Math.Round(Math.Cos(Math.Pow(x, 2)) + Math.Pow(Math.Sin(x), 2), 2));
    answerX.Add(x);
    x += start[2];
    points++;
}

for (int i = 1; i < points; i++) 
{
    if ((answerY[i] > 0 & answerY[i - 1] < 0) || (answerY[i] < 0 & answerY[i - 1] < 0))
    {
        intersections++;
    }
}

void Printer(List<double> arr, int count) 
{
    for (int i = 0; count != 0; i++)
    {
        Console.Write($"{arr[i]} ");
        count--;
    }
    Console.WriteLine();
}

Console.WriteLine("Таблица");
Printer(answerX, points);
Printer(answerY, points);

Console.WriteLine($"Mаксимальное значение функции: {answerY.Max()}");
Console.WriteLine($"Mинимальное значение функции: {answerY.Min()}");
Console.WriteLine($"Kоличество точек: {points}");
Console.WriteLine($"Пересечения: {intersections}");