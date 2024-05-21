using System.Diagnostics.Metrics;

string[] SeparationString(string symbolFromConsole)
{
    string[] SymbolArray = new string[symbolFromConsole.Length];
    SymbolArray = symbolFromConsole.Split(",");
    return SymbolArray
}

string[] HaveThreeSymbolArray(string[] array)
{
    int count = 0;
    for (int i = 0, i < array.Length; i++)
    {
        if (array [i].Length <= 3)
        {
            count ++;
        }
    }
}

Console.Write("Введите символы, разделенные запятой: "); 
string symbolFromConsole = Console.ReadLine();