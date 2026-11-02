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

    public string Rearrange()
    {
        return GetLetters() + GetDigits();
    }

    public void Display()
    {
        Console.WriteLine("Рядок: " + Value + ", Довжина: " + Length);
    }

    public int CompareTo(CustomString other)
{
    if (other == null) return 1;
    return string.CompareOrdinal(this.Value, other.Value);
}

    public override string ToString()
    {
        return Value;
    }
}