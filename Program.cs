string[] SeparationString(string symbolFromConsole)
{
    string[] SymbolArray = new string[symbolFromConsole.Length];
    SymbolArray = symbolFromConsole.Split(",");
    return SymbolArray
}

Console.Write("Введите символы, разделенные запятой: "); 
string symbolFromConsole = Console.ReadLine();