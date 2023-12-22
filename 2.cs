
using System;
using System.IO;
using System.Linq;
class work_5_2
{
    static void Main()
    {
        string content = File.ReadAllText("numsTask2.txt"); // чтение данных из файла
        string[] numbers = content.Split(';'); // разделение содержимого 
        float[] nums = Array.ConvertAll(numbers, float.Parse); // преобразуем строки в числа

        Array.Sort(nums); // сортировка по возрастанию
        string[] sortedNumbers = Array.ConvertAll(nums, x => x.ToString()); // чпреобразуем каждое число в строку
        string sortedContent = string.Join("; ", sortedNumbers); // соединяем в одну строку с разделителем
        
        File.WriteAllText("numsTask2.txt", sortedContent); // перезапись файла
    }
}