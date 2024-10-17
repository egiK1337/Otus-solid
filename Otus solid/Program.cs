
using Otus_solid.GameСlasses;

namespace Otus_solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameSettings settings = new GameSettings(100, 10);
            Game game = new Game(settings, new RandomNumberGenerator(), new ConsoleUserInput());
            game.Play();
        }
    }
}

//1.Single Responsibility Principle (SRP) - Принцип единой ответственности:
// Каждый класс выполняет одну задачу: GameSettings отвечает за настройки,
//RandomNumberGenerator — за генерацию чисел, ConsoleUserInput — за ввод данных от пользователя,
//а Game — за логику игры.

//2. Open/Closed Principle (OCP) -  Принцип открытости/закрытости:
// Мы можем расширять функциональность, добавляя новые реализации INumberGenerator или IUserInput,
// не изменяя уже существующие классы.

//3.Liskov Substitution Principle (LSP) -  Принцип подстановки Барбары Лисков:
// Мы можем использовать любые классы, реализующие интерфейсы INumberGenerator и IUserInput,
// без изменения поведения класса Game.

//4.Interface Segregation Principle (ISP) - принцип разделения интерфейсов:
// Интерфейсы разделены, и каждый клиент использует только необходимые методы. Например,
// INumberGenerator и IUserInput имеют свои специфические методы.

//5.Dependency Inversion Principle (DIP) - Принцип инверсии зависимостей:
//Класс Game зависит от абстракций (INumberGenerator и IUserInput),
//а не от конкретных реализаций. Это упрощает тестирование и замену зависимостей.

//На реализацию этого проекта ушло около 4-5 часов с учётом создаания второй версии программы с исправлениями замечаний.