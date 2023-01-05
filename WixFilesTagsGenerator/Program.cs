/*
 Copyright 2023 BLUE BYTE SYSTEMS INC.
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WixFilesTagsGenerator
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.WriteLine("Directory of files:");

            var dirPath = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(dirPath))
            {
                Console.WriteLine("Specified path is empty.");
                return;
            } 
            var dir = new DirectoryInfo(dirPath);


            if (dir.Exists == false)
            {
                Console.WriteLine($"{dir.FullName} does not exist or is not accessible.");
                return;
            }

            
            var ignoreFiles = new string[] { "solidworks.interop.sldworks.dll",
                                             "solidworks.interop.swconst.dll",
                                             "solidworks.interop.swcommands.dll",
                                             "solidworks.interop.swpublished.dll"};

            var files = dir.GetFiles().ToList().Where(x=> ignoreFiles.Contains(x.Name, StringComparer.OrdinalIgnoreCase) == false).Select(x => x.FullName).ToArray();


            if (files.Length == 0)
            {
                Console.WriteLine($"Empty dir");
                return;
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);

            var stringAppender = new StringBuilder();

            foreach (var file in files)
            {
                var fileName = System.IO.Path.GetFileName(file);
                stringAppender.AppendLine($@"<File Id='{fileName}ID' Name='{fileName}'  Source ='$(var.SourceOutDir)\{fileName}'/>");
            }

            Console.WriteLine(stringAppender.ToString());

            Console.WriteLine("Would you like to copy this to your clipboard? y / n: ");



            if (Console.ReadLine().ToLower() == "y")
                Clipboard.SetText(stringAppender.ToString());
            

            Console.ReadLine();

        }
    }
}
