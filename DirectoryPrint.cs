using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ESAExercise
{
    public static class DirectoryPrint
    {
        public static IEnumerable<string> PrintLowestTextFiles(string path)
        {
            //Using the System class, gather all directories within the path parameter, and convert the IEnumerable into a List so it can be sorted.
            var directories = Directory.EnumerateDirectories(path).ToList();

            /*Using Linq, find the deepest directory by sorting the directories by the number of directory separator characters, then selecting the first result.
            This can result in incomplete results if there are two or more equally deep directories. This can be solved by creating a List/array of final directories
            and performing the similar option. I opted to provide a simple solution here, using the example as inspiration. */
            string finalDirectory = directories.OrderByDescending(x => x.Split(Path.DirectorySeparatorChar).Length).FirstOrDefault();

            //using the yield return feature, return all relevant file paths as an IEnumerable<string>
            foreach (var file in Directory.EnumerateFiles(Path.GetFullPath(finalDirectory), "*.txt", SearchOption.TopDirectoryOnly))
            {
                yield return Path.GetFileName(file);
            }

        }

        public static void PrintHelper()
        {
            try
            {
                Console.Write("Enter a file path: ");
                string path = Console.ReadLine();
                var files = PrintLowestTextFiles(path);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception)
            {
                Console.Write("Sorry, not a valid file path. ");
            }
        }
        
    }
}
