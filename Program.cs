// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] array  = new string [5]{
    "array","show","room","five","hello"
};

string [] randomArray = new string [3];
Random rd = new Random(); //Объявляем генератор. 
// string[] i = new string[3]; //Создаем массив. 
for (int j = 0; j < array.Length; j++) 
{ 
randomArray[j] = rd.Next(string[] array); 
}
Console.WriteLine(randomArray);
