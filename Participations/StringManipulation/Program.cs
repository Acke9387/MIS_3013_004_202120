string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

Console.WriteLine(sentence);

Console.WriteLine("What word would you like to replace? >>");
string searchWord = Console.ReadLine();

Console.WriteLine($"What would you like to replace {searchWord} with? >>");
string replaceWord = Console.ReadLine();

if (sentence.Contains(searchWord) == true)
{
    //Replace the searchword with replaceword
    string newSentence = sentence.Replace(searchWord, replaceWord);
    //sentence = sentence.Replace(searchWord, replaceWord);

    Console.WriteLine(newSentence);
}
else
{
    Console.WriteLine($"Sorry, I could not find your word {searchWord}.");

    for (int i = searchWord.Length - 1; i >= 0; i--)
    {
        Console.Write(searchWord[i]);
    }

}