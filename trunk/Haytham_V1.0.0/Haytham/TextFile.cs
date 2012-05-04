using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Haytham
{
    public class TextFile
    {
        StreamWriter SW;

      public  string filenamewithoutextension; 

        public  TextFile(string filename)
        {
            CreateFile(filename);
        }

        private void CreateFile(string filename)
        {
            filenamewithoutextension = filename;

            SW = File.CreateText(filename +  ".txt");


        }
        public void CloseFile()
        {
            SW.Close();

        }

        public void WriteLine(string text)
        {
            SW.WriteLine(text);

        }
        public void Write(string text)
        {
            SW.Write(text);

        }
    }
}