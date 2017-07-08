using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04_Files
{
    public class Filee
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public BigInteger Size { get; set; }
    }

    public class Files
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());
            var fileList = new Dictionary<string, List<Filee>>();

            for (int i = 1; i <= lineNum; i++)
            {
                var fileLine = Console.ReadLine();
                var splitLine = fileLine
                    .Split(new char[] { '\\'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var root = splitLine[0];
                var lastPart = splitLine[splitLine.Length - 1];

                var splitLastPart = lastPart.Split(';').ToArray();

                var fileSize = BigInteger.Parse(splitLastPart[splitLastPart.Length -1]);
                var fileInformation = splitLastPart[0];
                var splFileInfo = fileInformation.Split('.').ToArray();

                
                var extension = splFileInfo[splFileInfo.Length - 1];
                var fileName = splFileInfo[0];

                if (splFileInfo.Length == 1)
                {
                    extension = "";
                }

                if (!fileList.ContainsKey(root))
                {
                    fileList[root] = new List<Filee>();
                    var newFile = CreateNewFile(fileName, extension, fileSize);
                    fileList[root].Add(newFile);
                }
                else
                {
                    var theFile = fileList[root]
                        .FirstOrDefault(f => f.Name == fileName && f.Extension == extension);

                    if (theFile != null)
                    {
                        theFile.Size = fileSize;
                    }
                    else
                    {
                        var newFile = CreateNewFile(fileName, extension, fileSize);
                        fileList[root].Add(newFile);
                    }
                }     
            }

            var querry = Console.ReadLine().Split(' ').ToArray();

            var ext = querry[0];
            var theRoot = querry[2];

            if (fileList.ContainsKey(theRoot))
            {
                var output = fileList[theRoot]
                    .Where(f => f.Extension.ToLower() == ext.ToLower())
                    .OrderByDescending(f => f.Size)
                    .ThenBy(f => f.Name)
                    .ToList();
                
                if (output.Count > 0)
                {
                    foreach (var f in output)
                    {
                        Console.WriteLine($"{f.Name}.{f.Extension} - {f.Size} KB");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static Filee CreateNewFile(string fileName, string extension, BigInteger fileSize)
        {
            var theFile = new Filee
            {
                Name = fileName,
                Extension = extension,
                Size = fileSize
            };

            return theFile;
        }
    }
}
