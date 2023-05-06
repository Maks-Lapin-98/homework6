int ReadInt(string argument) // проверка на число
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}

bool Validate(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            System.Console.WriteLine("прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] KrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    //double y = k1 * x + b1;
    double y = k2 * x + b2;
    double[] array = new double [2];
    array[0] = x;
    array[1] = y;
    return array;
    
}

int b1 = ReadInt("Введите b1: ");
int k1 = ReadInt("Введите k1: ");
int b2 = ReadInt("Введите b2: ");
int k2 = ReadInt("Введите k2: ");

if (Validate(b1, k1, b2, k2))
{
    System.Console.WriteLine($"[{string.Join(",", KrossPoint(b1, k1, b2, k2))}]");
}