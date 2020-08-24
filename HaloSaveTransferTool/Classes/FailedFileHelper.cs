using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HaloMCCPCSaveTransferTool
{
    internal static class FailedFileHelper
    {
        internal static string GetUniqueName(string originalPath)
        {
            if (originalPath != null && File.Exists(originalPath))
            {
                string directory = Path.GetDirectoryName(originalPath);
                string name = Path.GetFileNameWithoutExtension(originalPath);
                int i = 1;
                string extention = Path.GetExtension(originalPath);
                string newPath = directory + @"\" + name + " (" + i + ")" + extention;
                while (File.Exists(newPath))
                {
                    i++;
                    newPath = directory + @"\" + name + " (" + i + ")" + extention;
                }
                return newPath;
            }
            return null;
        }
        static string invalidChars = @"<>:" + '"' + @"/\|?*";
        internal static string ReplaceInvalidCharactersFromFileName(string fileName, char replaceCharacter = '_')
        {
            string retval = fileName;
            if (fileName != null && fileName.Length > 0)
            {
                retval = "";
                for (int i = 0; i < fileName.Length; i++)
                {
                    if (invalidChars.Contains(fileName[i].ToString()))
                    {
                        retval += replaceCharacter;
                    }
                    else
                    {
                        retval += fileName[i];
                    }
                }
            }
            return retval;
        }
    }
}
