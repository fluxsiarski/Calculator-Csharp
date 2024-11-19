namespace Kalkulator_firstApproach
{
    public class Dzialania
    {
        public static int Dodawanie(int zmienna1, int zmienna2)
        {
            return zmienna1 + zmienna2;
        }

        public static int Odejmowanie(int zmienna1, int zmienna2)
        {
            return zmienna1 - zmienna2;
        }

        public static int Mnozenie(int zmienna1, int zmienna2)
        {
            return zmienna1 * zmienna2;
        }
        
        public static double Dzielenie(int zmienna1, int zmienna2)
        {
            if (zmienna2 == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero.");
            }
            return (double)zmienna1 / zmienna2;
        }
        
        public static double Potegowanie(double podstawa, double wykladnik)
        {
            return Math.Pow(podstawa, wykladnik);
        }

        public static double Pierwiastkowanie(double liczba, double stopien)
        {
            if (stopien == 0)
            {
                throw new ArgumentException("Stopień pierwiastka nie może być zerowy.");
            }
            return Math.Pow(liczba, 1.0 / stopien);
        }
    }
}