// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void NegativeNumbers ()
{
    string enterRequest = "yes";
    int counter = 0;
    while(enterRequest != "no")
    {
        Console.Write("Enter a number = ");
        int number = int.Parse(Console.ReadLine()!);
        if (number < 0)
        {
            counter++;
        }
        Console.WriteLine("Do you want to enter one more number? Answer yes/no ");
        enterRequest = Convert.ToString(Console.ReadLine());
    }
    Console.Write("The number of negative numbers entered by the user is equal to: " + counter);

}
NegativeNumbers ();