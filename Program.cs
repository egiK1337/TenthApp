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

            var fileName1 = "File1.txt";
            var fileName5 = "File5.txt";
            var fileName10 = "File10.txt";

            var fileSystemManager = new FileSystemManager();

            fileSystemManager.Create(path, TestDir1);
            fileSystemManager.Create(path, TestDir2);

            for(var i = 1; i <= 10; i++)
            {
                fileSystemManager.Read(fileSystemManager.Add(dirForFile1, $"File{i}.txt"));
                fileSystemManager.Read(fileSystemManager.Add(dirForFile2, $"File{i}.txt"));
            }

            //var filePath1 = fileSystemManager.Add(dirForFile1, fileName1);
            //var filePath2 = fileSystemManager.Add(dirForFile1, fileName5);
            //var filePath3 = fileSystemManager.Add(dirForFile1, fileName10);
            //var filePath4 = fileSystemManager.Add(dirForFile2, fileName1);
            //var filePath5 = fileSystemManager.Add(dirForFile2, fileName5);
            //var filePath6 = fileSystemManager.Add(dirForFile2, fileName10);

            //fileSystemManager.Read(filePath1);
            //fileSystemManager.Read(filePath2);
            //fileSystemManager.Read(filePath3);
            //fileSystemManager.Read(filePath4);
            //fileSystemManager.Read(filePath5);
            //fileSystemManager.Read(filePath6);
        }
    }
}