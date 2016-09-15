namespace _05_Temperature
{
        public enum Unit
        {
            Fahrenheit,
            Celcius
        };

        public class Temperature
        {
            public int Fahrenheit;
            public int Celcius;

            public Temperature(Unit unit, int input)
            {
                Fahrenheit = input;
                Celcius = input;
            }
            public Temperature()
            {

            }

            internal static double FahrenheitToCelcius(double x)
            {
                //double y = (x - 32) / 1.80000;
                //string s = y.ToString().Replace('.', ',');
                //return Convert.ToDouble(s);

                double y = (x - 32) * 5 / 9;
                return y;
            }

            internal static double CelciusToFahrenheit(double v)
            {
                //double y = v * 5 / 9 + 32;
                //string s = y.ToString().Replace('.', ',');
                //return Convert.ToDouble(s);

                double y = v * 9 / 5 + 32;
                return y;
            }
        }
    }