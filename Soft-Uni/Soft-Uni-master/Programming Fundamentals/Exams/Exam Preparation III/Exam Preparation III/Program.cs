using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam_Preparation_III
{ 

public class Program 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var filesByRoot = new Dictionary<string, Dictionary<string, int>>();
            var filesByExtension = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var inputparams = Console.ReadLine().Split('\\').ToList();
                var root = inputparams[0];
                var fileParams = inputparams[inputparams.Count - 1].Split(new[] { '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var fileName = fileParams[0];
                var fileExtension = fileParams[1];
                var fileSize = int.Parse(fileParams[2]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot[root] = new Dictionary<string, int>();
                }
                filesByRoot[root][fileName] = fileSize;
                filesByExtension[fileExtension] = fileName;
            }

            var queryParams = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var queryextension = queryParams[0];
            var queryroot = queryParams[2];

            var extractedFiles = new Dictionary<string, int>();

            foreach (var extractedFile in filesByRoot[queryroot])
            {

            }
            
        }
    }
}
