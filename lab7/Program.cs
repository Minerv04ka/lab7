using System;

public class TextProcessor
{
    public string InputText { get; set; }

    public TextProcessor(string inputText)
    {
        InputText = inputText;
    }

    public int CalculateLength()
    {
        return InputText.Length;
    }

    public string ConvertToUpperCase()
    {
        return InputText.ToUpper();
    }

    public string ReverseText()
    {
        char[] charArray = InputText.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок тексту: ");
        string input = Console.ReadLine();

        TextProcessor processor = new TextProcessor(input);

        Console.WriteLine($"Довжина введеного тексту: {processor.CalculateLength()}");
        Console.WriteLine($"Рядок тексту у верхньому регістрі: {processor.ConvertToUpperCase()}");
        Console.WriteLine($"Рядок тексту навпаки: {processor.ReverseText()}");

        Console.ReadKey();
    }
}
