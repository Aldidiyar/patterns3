using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns3
{
    internal class DocumentReader : IDocumentReader
    {
        public void Read()
        {
            Console.WriteLine("Reading document");
        }
    }
}
