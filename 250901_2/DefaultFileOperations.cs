namespace _250901_2;

class DefaultFileOperations: IFileCopier
{
    static void Main(string[] args)
    {
        string text = "Hello World";
        System.IO.File.WriteAllText("text.txt", text);
        
        
        string sourceFilePath = "/Users/mr11/RiderProjects/polytech_csharp_study/250901_2/bin/Debug/net8.0/text.txt ";
        string destinationFilePath = "/Users/mr11/RiderProjects/polytech_csharp_study/250901_2/bin/Debug/net8.0/text.txt ";
        
        IFileCopier fileCopier = new DefaultFileOperations();

        try
        {
            fileCopier.CopyFile(sourceFilePath, destinationFilePath);
            Console.WriteLine("파일 복사");
        }

        catch (Exception ex)
        {
            Console.WriteLine("오류");
        }
    }
    
    public void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        System.IO.File.Copy(sourceFilePath, destinationFilePath, true);
    }
}
