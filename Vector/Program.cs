using System;

namespace Vector
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Создаем первый вектор:");
                Console.Write("Введите значение координаты x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение координаты y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение координаты z: ");
                double z = Convert.ToDouble(Console.ReadLine());

                Vector vectorA = new Vector(x, y, z);

                Console.WriteLine($"Вектор № 1: {vectorA}");

                Console.WriteLine("Создаем второй вектор:");
                Console.Write("Введите значение координаты x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение координаты y: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение координаты z: ");
                z = Convert.ToDouble(Console.ReadLine());

                Vector vectorB = new Vector(x, y, z);

                Console.WriteLine($"Вектор № 2: {vectorB}");

                Console.WriteLine($"\nРезультат сложения векторов: {vectorA + vectorB}");
                Console.WriteLine($"Результат вычитания вектора 2 из вектора 1: {vectorA - vectorB}");
                Console.WriteLine($"Результат векторного произведения: {vectorA * vectorB}");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }
        }
    }
}
