namespace CsharpStudy._2Season;

public class Word
{
    private string word;
    private int wordCount;
    public const string vowel = "a,e,i,o,u";
    
    public Word(string word)
    {
        this.word = word;
    }
   
    
    public bool IsVowel(int wordCount) //i번째 글자가 모음인지 알려주는 메서드
    {
        string[] splitVowels = vowel.Split(',');
        string wordLower = word.ToLower();
        
        char words = wordLower[wordCount];
        
        foreach (string splitVowel in splitVowels )
        {
            if (words.ToString().Equals(splitVowel))
            {
                return true;
            }
        }
        
        return false;
    }

    public bool IsConsonant(int wordCount)
    {
        string[] splitVowels = vowel.Split(',');
        string wordLower = word.ToLower();
        
        char words = wordLower[wordCount];
        
        foreach (string splitVowel in splitVowels )
        {
            if (words.ToString().Equals(splitVowel))
            {
                return false;
            }
        }
        
        return true;
    }
}

