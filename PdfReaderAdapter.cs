using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns3
{
    internal class PdfReaderAdapter : IDocumentReader
    {
        private PdfReader pdfReader;
        public PdfReaderAdapter(PdfReader pdfReader) 
        {
            this.pdfReader = pdfReader;
        }
        public void Read()
        {
            Console.WriteLine("Reading document");
        }
    }
}
