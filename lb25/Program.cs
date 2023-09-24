//85
//Дана последовательность вещественных чисел а1, a2, ..., а15.
//Определить, является ли она упорядоченной по возрастанию.
//В случае отрицательного ответа определить порядковый номер первого числа,
//нарушающего такую упорядоченность.
class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] sequence = new int[15];

        Console.WriteLine("Случайно сгенерированная последовательность из 15 целых чисел:");

        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = random.Next(1, 101); // Генерируем случайное целое число от 1 до 100
            Console.WriteLine($"Число {i + 1}: {sequence[i]}");
        }

        bool isOrdered = true;
        int violatingIndex = -1;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > sequence[i + 1])
            {
                isOrdered = false;
                violatingIndex = i + 2; // Порядковый номер первого числа, нарушающего упорядоченность
                break;
            }
        }

        if (isOrdered)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine($"Последовательность НЕ упорядочена по возрастанию. Нарушение упорядоченности на позиции {violatingIndex}.");
        }

        Console.ReadLine();
    }
}