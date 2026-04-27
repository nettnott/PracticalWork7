using System;

class ArrayExample
{
    ///<summary>
    ///Хранит массив символов, составляет из них имя и вызывает функцию SendMessage
    ///</summary>
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    ///<summary>
    ///Выводит в консоль приветствие
    ///</summary>
    ///<param name="name">Имя</param>
    ///<param name="msg">Номер последнего добавленного элемента массива</param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
