namespace TenthApp
{
    internal class Program
    {
        static void Main()
        {
            var path = @"C:\Otus\";
            var TestDir1 = @"TestDir1";
            var TestDir2 = @"TestDir2";

            var dirForFile1 = @"C:\Otus\TestDir1";
            var dirForFile2 = @"C:\Otus\TestDir2";

            var fileSystemManager = new FileSystemManager();

            fileSystemManager.Create(path, TestDir1);
            fileSystemManager.Create(path, TestDir2);

            for(var i = 1; i <= 10; i++)
            {
                fileSystemManager.Read(fileSystemManager.Add(dirForFile1, $"File{i}.txt"));
                fileSystemManager.Read(fileSystemManager.Add(dirForFile2, $"File{i}.txt"));
            }
        }
    }
}