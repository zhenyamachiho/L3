int GetNumber(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);


if(int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result < 100000)
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

int number = GetNumber("Введите число");
string numberString = Convert.ToString(number);

if (numberString[0] == numberString[4] && numberString[1] == numberString[3])
{
    Console.WriteLine("Yes");
}
    
else
{
    Console.WriteLine("No");
}








