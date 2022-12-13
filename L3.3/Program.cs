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
Console.WriteLine("Ввели не число. Введите число");
}
}

return result;
}

void PrintSquareTable (int number)
{
for (int i = 1; i <= number; i++)
{
Console.Write ($"{Math.Pow(i, 3)},");
}
}

int number = GetNumber("Введите число");

PrintSquareTable (number);
