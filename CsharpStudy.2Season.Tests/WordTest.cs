using CsharpStudy._2Season;

namespace CsharpStudy._2Season.Tests;

[TestFixture]
[TestOf(typeof(Word))]
public class WordTest
{

    [Test]
    public void 원하는_자리의_모음_맞추기()
    {
        Word word = new Word("Cyphers");

        word.IsVowel(4);

        Console.WriteLine(word.IsVowel(4));
    }
}