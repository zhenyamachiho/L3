int GetNumber(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);


if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Введите корректное число");
}
}

return result;
}

double GetDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2 ) + Math.Pow(z2 - z1, 2));
}

int x1 = GetNumber("Введите координату x1");
int y1 = GetNumber("Введите координату y1");
int z1 = GetNumber("Введите координату z1");
int x2 = GetNumber("Введите координату x2");
int y2 = GetNumber("Введите координату y2");
int z2 = GetNumber("Введите координату z2");

double distance = GetDistance(x1, y1, x2, y2, z1, z2);

Console.WriteLine(distance);