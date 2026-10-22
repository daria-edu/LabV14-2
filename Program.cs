using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- ПУНКТ 1: Перевірка методів ---");
        CustomString str = new CustomString("A1B2C3");
        str.Display();
        Console.WriteLine("Циفري: " + str.GetDigits());
        Console.WriteLine("Букви: " + str.GetLetters());
        Console.WriteLine("Перегруповано: " + str.Rearrange());

        Console.WriteLine("\n--- ПУНКТ 2: Масив та Колекції ---");

        // Масив
        CustomString[] array = new CustomString[2];
        array[0] = new CustomString("Hello12");
        array[1] = new CustomString("Test34");
        array[0] = new CustomString("NewVal56"); 
        Console.WriteLine("Масив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(" - " + array[i]);
        }

        // ArrayList (Non-Generic)
        ArrayList arrayList = new ArrayList();
        arrayList.Add(new CustomString("Item1"));
        arrayList.Add(new CustomString("Item2"));
        arrayList.RemoveAt(0); // видалення
        Console.WriteLine("ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(" - " + item);
        }

        // List<T> (Generic)
        List<CustomString> genericList = new List<CustomString>();
        genericList.Add(new CustomString("Cat12"));
        genericList.Add(new CustomString("Dog34"));
        Console.WriteLine("List<T>:");
        foreach (var item in genericList)
        {
            Console.WriteLine(" - " + item);
        }

        Console.WriteLine("\n--- ПУНКТ 3-4: Дерево (Postorder) ---");
        BinaryTree<CustomString> tree = new BinaryTree<CustomString>();
        tree.Add(new CustomString("M3"));
        tree.Add(new CustomString("B1"));
        tree.Add(new CustomString("Z9"));

        foreach (var item in tree)
        {
            Console.WriteLine(" - " + item);
        }
    }
}