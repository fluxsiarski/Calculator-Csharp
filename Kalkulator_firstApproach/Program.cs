using static System.Console;

namespace Kalkulator_firstApproach
{
    class Program
    {
        static void Main() 
        {
            WriteLine("Podaj pierwszą liczbę:");
            double zmienna1;
            while (!double.TryParse(ReadLine(), out zmienna1))
            {
                WriteLine("Podaj poprawną liczbę dla pierwszej liczby:");
            }

            WriteLine("Podaj drugą liczbę:");
            double zmienna2;
            while (!double.TryParse(ReadLine(), out zmienna2))
            {
                WriteLine("Podaj poprawną liczbę dla drugiej liczby:");
            }

            WriteLine("\nWybierz operację do wykonania:");
            WriteLine("1 - Dodawanie");
            WriteLine("2 - Odejmowanie");
            WriteLine("3 - Mnożenie");
            WriteLine("4 - Dzielenie");
            WriteLine("5 - Potęgowanie");
            WriteLine("6 - Pierwiastkowanie");
            WriteLine("7 - Wyjście");

            int wybor;
            while (!int.TryParse(ReadLine(), out wybor))
            {
                WriteLine("Podaj poprawny numer opcji:");
            }

            switch (wybor)
            {
                case 1:
                    WriteLine($"Wynik dodawania: {Dzialania.Dodawanie((int)zmienna1, (int)zmienna2)}");
                    break;
                case 2:
                    WriteLine($"Wynik odejmowania: {Dzialania.Odejmowanie((int)zmienna1, (int)zmienna2)}");
                    break;
                case 3:
                    WriteLine($"Wynik mnożenia: {Dzialania.Mnozenie((int)zmienna1, (int)zmienna2)}");
                    break;
                case 4:
                    try
                    {
                        double wynikDzielenia = Dzialania.Dzielenie((int)zmienna1, (int)zmienna2);
                        WriteLine($"Wynik dzielenia: {wynikDzielenia}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    WriteLine("Podaj wykładnik potęgi:");
                    double wykladnik;
                    while (!double.TryParse(ReadLine(), out wykladnik))
                    {
                        WriteLine("Podaj poprawny wykładnik:");
                    }
                    WriteLine($"Wynik potęgowania: {Dzialania.Potegowanie(zmienna1, wykladnik)}");
                    break;
                case 6:
                    WriteLine("Podaj stopień pierwiastka:");
                    double stopien;
                    while (!double.TryParse(ReadLine(), out stopien))
                    {
                        WriteLine("Podaj poprawny stopień pierwiastka:");
                    }
                    try
                    {
                        WriteLine($"Wynik pierwiastkowania: {Dzialania.Pierwiastkowanie(zmienna1, stopien)}");
                    }
                    catch (ArgumentException ex)
                    {
                        WriteLine(ex.Message);
                    }
                    break;
                case 7:
                    WriteLine("Zakończenie programu.");
                    return; 
                default:
                    WriteLine("Wybrano niepoprawną opcję.");
                    break;
            }

            WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            ReadLine(); 
        }
    }
}