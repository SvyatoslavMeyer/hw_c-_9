void Task64()
{
// Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    int m = 3;
    int n = 18;
    Console.WriteLine();
    Console.WriteLine("Задача № 64: ");
    Console.WriteLine();
    Recursion(m, n);
    void Recursion(int LeftBorder, int RightBorder)
    {
        if (LeftBorder > RightBorder) return;
        if (LeftBorder % 3 == 0) Console.WriteLine(LeftBorder);
        LeftBorder++;
        Recursion(LeftBorder, RightBorder);
    }
    Console.WriteLine("___________________________");
}

void Task66()
{
// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
    int m = 3;
    int n = 18;
    Console.WriteLine();
    Console.WriteLine("Задача № 66: ");
    Console.WriteLine();
    Recursion(m, n);
    void Recursion(int LeftBorder, int RightBorder, int sum = 0)
    {
        if (LeftBorder > RightBorder)
        {
            Console.WriteLine(sum);
            return;
        }
        sum += LeftBorder;
        LeftBorder++;
        Recursion(LeftBorder, RightBorder, sum);
    }  
    Console.WriteLine("___________________________");  
}

void Task68()
{
// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 

    int m = 3;
    int n = 4;
    Console.WriteLine();
    Console.WriteLine("Задача № 68: ");
    Console.WriteLine();
    Console.WriteLine(Recursion(m, n));
    int Recursion(int LeftBorder, int RightBorder)
    {
        if (LeftBorder == 0) return RightBorder+1;
        else if(RightBorder  == 0) return Recursion(LeftBorder - 1, 1);
        else if (LeftBorder > 0 && RightBorder > 0) return (Recursion(LeftBorder - 1, Recursion(LeftBorder, RightBorder - 1)));
        else return 0;
    }
    Console.WriteLine("___________________________");
}

// Задачи:

Task64();
Task66();
Task68();
