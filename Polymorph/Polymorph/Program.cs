namespace Polymorph
{
    internal class Program
    {
        static void Main()
        {
            // Примеры вызова методов Convert
            if (CustomConverter.Convert("123", out int intResult))
            {
                Console.WriteLine($"intResult: {intResult}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в int");
            }

            if (CustomConverter.Convert("0,34", out double doubleResult))
            {
                Console.WriteLine($"doubleResult: {doubleResult}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в double");
            }

            if (CustomConverter.Convert("true", out bool boolResult))
            {
                Console.WriteLine($"boolResult: {boolResult}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в bool");
            }

            if (CustomConverter.Convert("2024-09-09", out DateTime dateTimeResult))
            {
                Console.WriteLine($"dateTimeResult: {dateTimeResult}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в DateTime");
            }

            if (CustomConverter.Convert("1234567890123", out long longResult))
            {
                Console.WriteLine($"longResult: {longResult}");
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать строку в long");
            }
        }
    }
}
