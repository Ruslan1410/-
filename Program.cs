// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

class Program
    {
        static void Main(string[] args)
        {
            string[] array = new[] {"boo", "test", "123", "yell", "eat", ":-)"};
            
            string[] endArray = new string[array.Length];
 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    endArray[i] = array[i];
                }
            }
 
            foreach (var S in endArray)
            {
                if (S != null)
                {
                    Console.WriteLine(S);
                }
            }
        }
    }