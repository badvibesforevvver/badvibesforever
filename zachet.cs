using System;

class Program
{
    static void Main()
    {
        int[] array = new int[0];

        while (true)
        {
            Console.WriteLine("Введите число для добавления массива, 'удалить' для удаления элемента или 'выход' для закрытия программы:");
            string input = Console.ReadLine();

            if (input == "выход")
            {
                break;
            }
            else if (input == "удалить")
            {
                Console.WriteLine("Введите индекс элемента для удаления:");
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < array.Length)
                {
                    int[] newArray = new int[array.Length - 1];
                    for (int i = 0; i < index; i++)
                    {
                        newArray[i] = array[i];
                    }
                    for (int i = index + 1; i < array.Length; i++)
                    {
                        newArray[i - 1] = array[i];
                    }
                    array = newArray;
                }
                else
                {
                    Console.WriteLine("Неправильный индекс");
                }
            }
            else
            {
                int number = int.Parse(input);
                int[] newArray = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[array.Length] = number;
                array = newArray;
            }

            Console.WriteLine("Текущий массив:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Программа закрыта.");
    }
}
