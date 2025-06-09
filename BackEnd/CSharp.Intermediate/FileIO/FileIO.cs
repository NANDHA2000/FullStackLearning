/* FileIO Def
 
   -- File I/O = Input and Output operations with Files.

   -- Reading from / writing to files on disk.

Common classes:

     ** File
     
     ** FileInfo
     
     ** StreamReader
     
     ** StreamWriter
 
 */

namespace CSharp.Intermediate.FileIO
{
    public class FileIO
    {
        public static void FileIOEx()
        {
            string path = "example.txt";

            // Write to file
            File.WriteAllText(path, "Hello, this is File I/O Example!");

            // Append text to file
            File.AppendAllText(path, "\nAdding more content.");

            // Read from file
            string content = File.ReadAllText(path);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);

            // Clean up (optional)
            // File.Delete(path);
        }

    }
}
