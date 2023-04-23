
using System;
using System.IO;
namespace Files;
//ДЗ 003
class Program
{
    static void Main(string[] args)
    {
        string directoryPath;

        if (args.Length == 0)// проверяем переданы ли аргументы в cmd : например путь к каталогу
        {
            directoryPath = Directory.GetCurrentDirectory();//Если нет аргументов - получаем  путь к текущему каталогу и записываем его как строковое значение
        }
        else
        {
            directoryPath = args[0]; //записываем строковое значение  в качестве первого аргумента в массиве.
        }

        Console.WriteLine($"Список файлов и папок в каталоге: {directoryPath}");

        try
        {
            string[] directories = Directory.GetDirectories(directoryPath);// метод извлекает путь  к каталогу  и записывает его в массив
            foreach (string directory in directories)//перебирает каждый элемент пути
            {
                Console.WriteLine($"Каталог: {directory}");
            }

            string[] files = Directory.GetFiles(directoryPath);// метод извлекает путь  к файлу  и записывает его в массив
            foreach (string file in files)
            {
                Console.WriteLine($"Файл: {file}");//перебирает каждый элемент пути
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
