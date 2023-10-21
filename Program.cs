using System;

namespace Patterns3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDocumentReader document = new DocumentReader();
            document.Read();
            PdfReader pdfDocument = new PdfReader();
            IDocumentReader pdfAdapter = new PdfReaderAdapter(pdfDocument);
            pdfAdapter.Read();
        }
    }
}
