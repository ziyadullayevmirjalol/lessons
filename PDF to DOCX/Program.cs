using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string pdfFilePath = @"C:\Users\trash\source\repos\lessons\PDF to DOCX\file.pdf";
        string docxFilePath = @"C:\Users\trash\source\repos\lessons\PDF to DOCX\file.docx";

        try
        {
            // Extract text from PDF
            string pdfText = ExtractTextFromPdf(pdfFilePath);

            // Create a new DOCX file
            CreateDocxFile(docxFilePath, pdfText);

            Console.WriteLine("Conversion successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static string ExtractTextFromPdf(string pdfFilePath)
    {
        StringBuilder text = new StringBuilder();

        // This is a very basic text extraction approach, and it won't work well for most PDFs.
        // It assumes that the PDF is a simple text document without complex structures.
        using (StreamReader reader = new StreamReader(pdfFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                text.AppendLine(line);
            }
        }

        return text.ToString();
    }

    static void CreateDocxFile(string docxFilePath, string content)
    {
        File.WriteAllText(docxFilePath, content);
    }
}
