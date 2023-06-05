class Program
{
    static void Main()
    {
        // Ввводим первоначальный массив с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] original = input.Split(',');

        // Считаем количество строк, подходящих по условию
        int count = 0;
        foreach (string str in original)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] result = new string[count];

        // Копируем строки из первоначального массива, подходящие по условию
        int index = 0;
        foreach (string str in original)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

// Выводим новый массив на экран
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
