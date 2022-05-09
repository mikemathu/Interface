using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeProgram
{
    public class TextFileWriter : IFileWriter
    {
        public string Extension
        {
            get { return ".txt"; }
        }
        public void Write(string filename)
        {
            // Do your file writing here...
        }
    }

}
