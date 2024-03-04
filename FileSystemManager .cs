
namespace TenthApp
{
    public class FileSystemManager
    {
        public string Add(string path, string fileName)
        {
            var filePath = Path.Combine(path, fileName);
            using var stream1 = File.CreateText(filePath);

            stream1.WriteLine($"{DateTime.Now}");
            stream1.WriteLine($"{fileName}");

            return filePath;
        }

        public void Create(string path, string subPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            directoryInfo.CreateSubdirectory(subPath);
        }

        public void Read(string filePath)
        {
            var textLines = File.ReadAllLines(filePath);
            foreach (var line in textLines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
