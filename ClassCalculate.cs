namespace ClassLibraryCalculation
{
    public class ClassCalculate
    {
        public double addition(double value1, double value2)
        {
            return value1 + value2;
        }
        public double addition(string value1, string value2)
        {
            double val1 = 0;
            double val2 = 0;
            if (value1 == "five")
                 val1 = 5;
            if (value2 == "ten")
                val2 = 10;
            return val1 + val2;
        }

        public double subtraction(double value1, double value2)
        {
            return value1 - value2;
        }

        public double multiplication(double value1, double value2)
        {
            return value1 * value2;
        }

        public double division(double value1, double value2)
        {
            return value1 / value2;
        }
    }
}