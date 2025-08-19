namespace CsharpStudy._2Season;

public class Word
{
    private string word;
    private int wordCount;
    public const string vowel = "a,e,i,o,u";
    
    Word(string word, int wordCount)
    {
        this.word = word;
        this.wordCount = wordCount;
    }
   
    

    public bool isVowel(int wordCount) //i번째 글자가 모음인지 알려주는 메서드
    {
        string[] splitVowel = vowel.Split(',');
        string wordLower = word.ToLower();

        string[] splitWord = wordLower.Split("");

        foreach (string splitVowels in splitVowel )
        {
            return splitWord[wordCount] == splitVowels;
        }
        
        return false;
    }
}

