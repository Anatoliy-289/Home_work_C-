using System.Diagnostics.Metrics;

int size = x; // размер (длина) массива
string[] firstArray = new string[array.Length];

Console.WriteLine("Введите символы, разделенные запятой: "); 
string symbolFromConsole = Console.ReadLine();

string[] SeparationString(string symbolFromConsole)
{
    string[] SymbolArray = new string[symbolFromConsole.Length];
    SymbolArray = symbolFromConsole.Split(",");
    return SymbolArray;
}

int HaveThreeAndLessSymbolArray(string[] SerarationString)
{
    int count = 0;
    for (int i = 0, i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            count ++;
        }
        else
        {
            Console.Write("Элементы, длина которых менее трех симвовлов, отсутствуют.");
        }
    
    }
    return count;

}

string[] NewThreeAndLessSymbolArray(string[] HaveThreeAndLessSymbolArray);
    
{    
    string[] ThreeOrLessSymbolArray = new string [HaveThreeAndLessSymbolArray(firstArray)];
    for(int i = 0, k = 0, i < HaveThreeAndLessSymbolArray.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            ThreeOrLessSymbolArray[k] = array[i];
            k++;
        }
    }

}