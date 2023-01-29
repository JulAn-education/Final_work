Console.Write("Input a word or symbols: ");
string word1 = Console.ReadLine();
Console.Write("Input a word or symbols: ");
string word2= Console.ReadLine();
Console.Write("Input a word or symbols: ");
string word3 = Console.ReadLine();
Console.Write("Input a word or symbols: ");
string word4 = Console.ReadLine();

string[] array = new string[] {word1, word2, word3, word4};
string[] newarray = new string[array.Length];


void SortingArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count++;
        } 
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SortingArray(array, newarray);
ShowArray(newarray);


