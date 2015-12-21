using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Novacode;

namespace Problem5.WordDocumentGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = 
                @"C:\Users\pc1\Desktop\HomeworkOtherTypesInOOP\Problem5.WordDocumentGenerator\Resources\RPG-Text-And-Photo.docx";

            DocX document = DocX.Create(name);

            string[] text = 
                File.ReadAllLines(@"C:\Users\pc1\Desktop\HomeworkOtherTypesInOOP\Problem5.WordDocumentGenerator\Resources\text.txt");

            var headLineFormat = new Formatting();
            headLineFormat.Size = 26D;
            headLineFormat.Bold = true;

            Paragraph title = document.InsertParagraph(text[0], false, headLineFormat);

            Paragraph pictureParagraph = document.InsertParagraph();

            using (MemoryStream ms = new MemoryStream())
            {
                System.Drawing.Image myImage = 
                    System.Drawing.Image.FromFile(@"C:\Users\pc1\Desktop\HomeworkOtherTypesInOOP\Problem5.WordDocumentGenerator\Resources\rpg-game.png");
                double Horizontal = (double)22 / myImage.HorizontalResolution;
                double Vertical = (double)22 / myImage.VerticalResolution;

                myImage.Save(ms, myImage.RawFormat);
                ms.Seek(0, SeekOrigin.Begin);

                Novacode.Image img = document.AddImage(ms);
                Picture pic1 = img.CreatePicture();  

                pic1.Height = (int)(myImage.Height * Horizontal);
                pic1.Width = (int)(myImage.Width * Vertical);

                pictureParagraph.InsertPicture(pic1, 0);
            }

            Formatting paragraphFormat = new Formatting();

            for (int i = 1; i < 4; i++)
            {
                document.InsertParagraph(text[i], false, paragraphFormat);
            }

            var bullets = document.AddList(text[4], 0, ListItemType.Bulleted);
            document.AddListItem(bullets, text[5]);
            document.AddListItem(bullets, text[6]);
            document.InsertList(bullets);

            document.InsertParagraph();

            Table table = document.AddTable(4, 3);
            table.Design = TableDesign.MediumGrid1Accent1;
            table.Alignment = Alignment.center;

            string[] tableRow1 = Regex.Split(text[8], @"\s+");
            string[] tableRow2 = Regex.Split(text[9], @"\s+");
            string[] tableRow3 = Regex.Split(text[10], @"\s+");
            string[] tableRow4 = Regex.Split(text[11], @"\s+");

            table.Rows[0].Cells[0].Paragraphs[0].Append(tableRow1[0]);
            table.Rows[0].Cells[1].Paragraphs[0].Append(tableRow1[1]);
            table.Rows[0].Cells[2].Paragraphs[0].Append(tableRow1[2]);
            table.Rows[1].Cells[0].Paragraphs[0].Append(tableRow2[0]);
            table.Rows[1].Cells[1].Paragraphs[0].Append(tableRow2[1]);
            table.Rows[1].Cells[2].Paragraphs[0].Append(tableRow2[2]);
            table.Rows[2].Cells[0].Paragraphs[0].Append(tableRow3[0]);
            table.Rows[2].Cells[1].Paragraphs[0].Append(tableRow3[1]);
            table.Rows[2].Cells[2].Paragraphs[0].Append(tableRow3[2]);
            table.Rows[3].Cells[0].Paragraphs[0].Append(tableRow4[0]);
            table.Rows[3].Cells[1].Paragraphs[0].Append(tableRow4[1]);
            table.Rows[3].Cells[2].Paragraphs[0].Append(tableRow4[2]);

            document.InsertTable(table);

            document.InsertParagraph();
            Paragraph prizeLine = document.InsertParagraph(text[13]);
            prizeLine.Alignment = Alignment.center;

            Paragraph prize = 
                document.InsertParagraph(text[14]).Bold().FontSize(24D).Color(Color.DarkBlue).UnderlineStyle(UnderlineStyle.singleLine);
            prize.Alignment = Alignment.center;

            document.Save();

            Process.Start("Word.exe", name);
        }
    }
}
