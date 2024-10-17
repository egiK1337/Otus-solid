// Основной класс игры
using Otus_solid.GameInterfaces;
using Otus_solid.GameСlasses;

public class Game
{
    private GameSettings _settings;
    private INumberGenerator _numberGenerator;
    private IUserInput _userInput;
    private int _secretNumber;
    private int _attempts;

    public Game(GameSettings settings, INumberGenerator numberGenerator, IUserInput userInput)
    {
        _settings = settings;
        _numberGenerator = numberGenerator;
        _userInput = userInput;
        _secretNumber = _numberGenerator.Generate(_settings.NumberRange);
    }

    public void Play()
    {
        while (_attempts < _settings.MaxAttempts)
        {
            int guess = _userInput.GetInput();
            _attempts++;

            if (guess < _secretNumber)
            {
                Console.WriteLine("Больше!");
            }
            else if (guess > _secretNumber)
            {
                Console.WriteLine("Меньше!");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Вы угадали число {_secretNumber} за {_attempts} попыток.");
                return;
            }
        }
        Console.WriteLine($"Вы исчерпали все попытки. Загаданное число было {_secretNumber}.");
    }
}
