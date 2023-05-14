using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Меню выбора:");
        Console.WriteLine("1. Ввести А");
        Console.WriteLine("2. Ввести В");
        Console.WriteLine("3. Выполнить операцию '+'");
        Console.WriteLine("5. Выполнить операцию '*'");

        int choice;
        double a = 0, b = 0;
        bool hasA = false, hasB = false;

        do
        {
            Console.Write("Введите номер операции (или 0 для выхода): ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка! Введите число от 0 до 6.");
                continue;
            }

            try
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Выход...");
                        break;
                    case 1:
                        Console.Write("Введите значение А: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        hasA = true;
                        break;
                    case 2:
                        Console.Write("Введите значение В: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        hasB = true;
                        break;
                    case 3:
                        if (!hasA || !hasB)
                        {
                            Console.WriteLine("Ошибка! Введите значения А и В перед выполнением операции.");
                            continue;
                        }
                        Console.WriteLine($"Результат сложения: {a + b}");
                        break;
                    case 5:
                        if (!hasA || !hasB)
                        {
                            Console.WriteLine("Ошибка! Введите значения А и В перед выполнением операции.");
                            continue;
                        }
                        Console.WriteLine($"Результат умножения: {a * b}");
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите числовое значение.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Введено слишком большое или слишком маленькое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine();
        } while (choice != 0);
    }
}
