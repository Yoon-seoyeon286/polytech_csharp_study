namespace _250901_2;

class DefaultFileOperations: IFileCopier
{
    static void Main(string[] args)
    {
        string text = "Hello World";
        System.IO.File.WriteAllText("text.txt", text);


    }
    
    public void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        throw new NotImplementedException();
    }
}
