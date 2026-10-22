using System;

// Клас за варіантом 14
public class CustomString : IComparable<CustomString>
{
    public string Value;
    public int Length;

    public CustomString(string value)
    {
        Value = value;
        Length = value.Length;
    }

    // 1. Отримання підрядка з цифрами
    public string GetDigits()
    {
        string res = "";
        for (int i = 0; i < Value.Length; i++)
        {
            if (char.IsDigit(Value[i]))
            {
                res = res + Value[i];
            }
        }
        return res;
    }

    // 2. Отримання підрядка з буквами
    public string GetLetters()
    {
        string res = "";
        for (int i = 0; i < Value.Length; i++)
        {
            if (char.IsLetter(Value[i]))
            {
                res = res + Value[i];
            }
        }
        return res;
    }

    // 3. Перегрупування символів (спочатку букви, потім цифри)
    public string Rearrange()
    {
        return GetLetters() + GetDigits();
    }

    // 4. Виведення рядка
    public void Display()
    {
        Console.WriteLine("Рядок: " + Value + ", Довжина: " + Length);
    }

    // Для порівняння та сортування
    public int CompareTo(CustomString other)
    {
        return string.Compare(this.Value, other.Value);
    }

    public override string ToString()
    {
        return Value;
    }
}