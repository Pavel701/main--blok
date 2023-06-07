
class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();

        // Разделение введенной строки на элементы массива
        string[] inputArray = input.Split(',');

        // Создание нового массива
        string[] newArray = new string[inputArray.Length];
        int newIndex = 0;

        // Фильтрация элементов исходного массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            string element = inputArray[i].Trim();

            if (element.Length <= 3)
            {
                newArray[newIndex] = element;
                newIndex++;
            }
        }

        // Вывод нового массива в одну строку
        Console.Write("Новый массив: [");
        for (int i = 0; i < newIndex; i++)
        {
            Console.Write(newArray[i]);

            // Добавление запятой после каждого элемента, кроме последнего
            if (i < newIndex - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

    }
}