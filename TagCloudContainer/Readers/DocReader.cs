﻿using Spire.Doc;
using Spire.Doc.Documents;
using System.Text;


namespace TagCloudContainer.Readers
{
    public class DocReader : IFileReader
    {
        public string Read(string path)
        {
            var stringBuilder = new StringBuilder();
            var document = new Document(path);
            foreach (Section section in document.Sections)
            foreach (Paragraph paragraph in section.Paragraphs)
                stringBuilder.AppendLine(paragraph.Text);
            return stringBuilder.ToString();
        }
    }
}