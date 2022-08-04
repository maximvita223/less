Console.Clear();

Console.Write("введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
    Console.Write("Число 1 является корнем 2");
else
    Console.Write("Число 1 не является корнем 2");

