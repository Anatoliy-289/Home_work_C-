
string [] SeparationString (string symbol)
{
    string [] SymbolArray = new string [symbol.Length];
    SymbolArray = symbol.Split(",");
    return SymbolArray
}