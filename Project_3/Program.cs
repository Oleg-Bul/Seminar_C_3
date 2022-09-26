//Задача 28
//Напишите программу, которая принимает на вход
//число N и выдаёт произведение чисел от 1 до N.

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}


long Fuktor(int num)
{
    long res = 1;
    for (int i = 1; i < num; i++)
    {
        res = res * i;
    }

    return res;
}



void PrintData(string msg, long value)
{
    Console.WriteLine(msg + value);
}
int numN = ReadData("Введите число N: ");
long outResult = Fuktor(numN);
PrintData("Факториал числа  "+numN+ " равен ", outResult);