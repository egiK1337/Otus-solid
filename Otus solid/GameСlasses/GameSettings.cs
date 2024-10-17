
namespace Otus_solid.GameСlasses
{
    // Класс для хранения настроек игры
    public class GameSettings
    {
        public int NumberRange { get; }
        public int MaxAttempts { get; }

        public GameSettings(int numberRange, int maxAttempts)
        {
            NumberRange = numberRange;
            MaxAttempts = maxAttempts;
        }
    }
}
