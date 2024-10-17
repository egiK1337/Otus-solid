// Реализация ввода пользователя
public class ConsoleUserInput : IUserInput
{
    public int GetInput()
    {
        Console.Write("Введите ваше число: ");
        return int.Parse(Console.ReadLine());
    }
}
