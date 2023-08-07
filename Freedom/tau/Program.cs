var InputFile = new StreamReader("input.txt");
var InputPhraseArray = InputFile.ReadLine().Split(" ").ToList<string>();
InputFile.Close();
var OutputFile = new StreamWriter("output.txt");
OutputFile.WriteLine(NewPhrase(InputPhraseArray));
OutputFile.Close();
string NewPhrase(List<string> InputPhraseArray)
{
    var OutputPhraseArray = new List<string>() { NewWord(InputPhraseArray[InputPhraseArray.Count() / 2]) };
    InputPhraseArray.RemoveAt(InputPhraseArray.Count() / 2);
    int k = 0;
    if (InputPhraseArray.Count() % 2 != 0)
    {
        OutputPhraseArray.Add(InputPhraseArray[InputPhraseArray.Count() / 2]);
        InputPhraseArray.RemoveAt(InputPhraseArray.Count() / 2);
    }
    for (int i = InputPhraseArray.Count() / 2 - 1; i >= 0; i--)
    {
        OutputPhraseArray.Add(NewWord(InputPhraseArray[i]));
        if (InputPhraseArray.Count() / 2 + k < InputPhraseArray.Count())
        {
            OutputPhraseArray.Add(NewWord(InputPhraseArray[InputPhraseArray.Count / 2 + k]));
            k += 1;
        }
    }
    return String.Join(" ", OutputPhraseArray);
}
string NewWord(string word)
{
    List<char> wordArray = word.ToCharArray().ToList<Char>();
    var newWordArray = new List<Char>() { wordArray[wordArray.Count() / 2] };
    wordArray.RemoveAt(wordArray.Count() / 2);
    int k = 0;
    if (wordArray.Count() % 2 != 0)
    {
        newWordArray.Add(wordArray[wordArray.Count() / 2]);
        wordArray.RemoveAt(wordArray.Count() / 2);
    }
    for (int i = wordArray.Count() / 2 - 1; i >= 0; i--)
    {
        newWordArray.Add(wordArray[i]);
        if (wordArray.Count() / 2 + k < wordArray.Count())
        {
            newWordArray.Add(wordArray[wordArray.Count / 2 + k]);
            k += 1;
        }
    }
    return String.Join("", newWordArray);
}