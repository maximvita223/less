Console.Clear();

Console.Write("введите число дня недели: ");

int day = Convert.ToInt32(Console.ReadLine());

if (1 > day || 7 < day)
{
    Console.Write("incorrect num");
}
else 
{
    if (day == 1)
    {
        Console.Write("понедельник");
    }
    if (day == 2)
    {
        Console.Write("вторник");
    }
    if (day == 3)
    {
        Console.Write("среда");
    }
    if (day == 4)
    {
        Console.Write("четверг");
    }
    if (day == 5)
    {
        Console.Write("пятница");
    }
    if (day == 6){
    Console.Write("суббота");
    }
        if (day == 6)
    {
        Console.Write("воскресенье");
    }
}