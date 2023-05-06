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
int[] MakeArray(int m) //массив длинной m
{
    int[] array = new int [m];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt("Введите число: "); 
    }
    return array;
}
int NotZerro(int[]array) //проверяем сколько чисел больше нуля
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int m = ReadInt("Укажите количество чисел: ");
System.Console.WriteLine($"{NotZerro(MakeArray(m))} чисел(а) больше нуля");