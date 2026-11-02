using System;
using System.Collections;
using System.Collections.Generic;


class LengthComparer : IComparer<CustomString>
{
    public int Compare(CustomString a, CustomString b)
    {
        return a.Length.CompareTo(b.Length);
    }
}

class Program
{
    static void Print(string title, IEnumerable items)
    {
        Console.WriteLine(title);
        foreach (var item in items)
        {
            Console.WriteLine(" - " + item);
        }
    }

    static void Main()
    {
        
        Console.WriteLine("--- ПУНКТ 1: Перевірка методів ---");
        CustomString str = new CustomString("A1B2C3");
        str.Display();
        Console.WriteLine("Цифри: " + str.GetDigits());
        Console.WriteLine("Букви: " + str.GetLetters());
        Console.WriteLine("Перегруповано: " + str.Rearrange());

        
        Console.WriteLine("\n--- ПУНКТ 2: Масив ---");
        CustomString[] array = new CustomString[4];
        array[0] = new CustomString("Hello12");
        array[1] = new CustomString("Test34");
        array[2] = new CustomString("World56");
        array[3] = new CustomString("Data78");
        Print("Додано 4 елементи:", array);

        array[0] = new CustomString("NewVal99"); 
        Print("Після оновлення [0]:", array);

        CustomString foundA = Array.Find(array, x => x.Value == "Test34"); 
        Console.WriteLine("Пошук 'Test34': " + (foundA != null ? "знайдено" : "не знайдено"));

        
        for (int i = 1; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        Array.Resize(ref array, array.Length - 1);
        Print("Після видалення [1]:", array);

        Console.WriteLine("\n--- ПУНКТ 2: ArrayList ---");
        ArrayList arrayList = new ArrayList();
        arrayList.Add(new CustomString("Item1"));
        arrayList.Add(new CustomString("Item2"));
        arrayList.Add(new CustomString("Item3"));
        arrayList.Add(new CustomString("Item4"));
        Print("Додано 4 елементи:", arrayList);

        arrayList[0] = new CustomString("Updated1"); 
        Print("Після оновлення [0]:", arrayList);

        bool foundB = false;
        foreach (CustomString s in arrayList)
        {
            if (s.Value == "Item3") foundB = true;
        }
        Console.WriteLine("Пошук 'Item3': " + (foundB ? "знайдено" : "не знайдено"));

        arrayList.RemoveAt(1); 
        Print("Після видалення [1]:", arrayList);

        Console.WriteLine("\n--- ПУНКТ 2: List<T> ---");
        List<CustomString> genericList = new List<CustomString>();
        genericList.Add(new CustomString("Cat12"));
        genericList.Add(new CustomString("Dog34"));
        genericList.Add(new CustomString("Bird56"));
        genericList.Add(new CustomString("Fish78"));
        Print("Додано 4 елементи:", genericList);

        genericList[0] = new CustomString("Lion00");
        Print("Після оновлення [0]:", genericList);

        CustomString foundC = genericList.Find(x => x.Value == "Bird56"); 
        Console.WriteLine("Пошук 'Bird56': " + (foundC != null ? "знайдено" : "не знайдено"));

        genericList.RemoveAt(1); 
        Print("Після видалення [1]:", genericList);

        
        Console.WriteLine("\n--- ПУНКТ 3-4: Дерево (IComparable, postorder) ---");
        BinaryTree<CustomString> tree = new BinaryTree<CustomString>();
        tree.Add(new CustomString("M3"));
        tree.Add(new CustomString("B1"));
        tree.Add(new CustomString("Z9"));
        tree.Add(new CustomString("D4"));
        Print("Обхід дерева:", tree);

        Console.WriteLine("\n--- ПУНКТ 4: Дерево з IComparer (за довжиною) ---");
        BinaryTree<CustomString> tree2 = new BinaryTree<CustomString>(new LengthComparer());
        tree2.Add(new CustomString("A1"));
        tree2.Add(new CustomString("B12345"));
        tree2.Add(new CustomString("C123"));
        tree2.Add(new CustomString("D12"));
        Print("Обхід дерева:", tree2);

        Console.WriteLine("\n--- Дерево з іншим типом (int) ---");
        BinaryTree<int> intTree = new BinaryTree<int>();
        intTree.Add(5);
        intTree.Add(2);
        intTree.Add(8);
        intTree.Add(1);
        Print("Обхід дерева:", intTree);
    }
}