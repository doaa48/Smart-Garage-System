using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

public class PdfExporter : PdfPageEventHelper
{
    private readonly string _title;
    private readonly string _imagePath;
    private readonly Paragraph _headerParagraph;  // Field to store the header

    public PdfExporter(string title, string headerParagraph)
    {
        _title = title;
        //_imagePath = imagePath;


        Font headerFont = new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD);
        Paragraph header = new Paragraph(headerParagraph, headerFont)
        {
            Alignment = Element.ALIGN_CENTER
        };
       
        _headerParagraph = header;
    }

    public void ExportDataGridViewToPdf(DataGridView dataGridView)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = "ExportedData"; // Default file name

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Create a new PDF document
                Document document = new Document(PageSize.A4, 36, 36, 54, 54); // Added margins for header and footer
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                    writer.PageEvent = this; // Attach event handler for header/footer
                    document.Open();

                    // Title with Image
                    /* if (!string.IsNullOrEmpty(_imagePath) && File.Exists(_imagePath))
                     {
                         Image img = Image.GetInstance(_imagePath);
                         img.ScaleAbsolute(50, 50); // Adjust image size
                         img.Alignment = Image.ALIGN_LEFT;
                         document.Add(img);
                     }*/

                    document.Add(new Paragraph("\n"));
                    // Title text
                    Font titleFont = new Font(Font.FontFamily.TIMES_ROMAN, 10, Font.BOLD);
                    
                    Paragraph titleParagraph = new Paragraph(_title, titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER,

                    };
                    document.Add(titleParagraph);

                    // Space after title
                    document.Add(new Paragraph("\n\n"));

                    // Define a font with a smaller size
                    Font smallFont = new Font(Font.FontFamily.TIMES_ROMAN, 6); // Adjust the font size as needed

                    // Create a table with the same number of columns as the DataGridView
                    PdfPTable table = new PdfPTable(dataGridView.Columns.Count)
                    {
                        DefaultCell = { Padding = 2 },
                        WidthPercentage = 110,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };

                    // Add headers
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, smallFont))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY,
                            MinimumHeight = 25, // Adjust height as needed
                            FixedHeight = 30 // Adjust height to fit the content or header
                        };
                        table.AddCell(cell);
                    }

                    // Add rows
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? string.Empty, smallFont))
                            {
                                MinimumHeight = 25, // Adjust height as needed
                                FixedHeight = 30 // Adjust height to fit the content
                            };
                            table.AddCell(pdfCell);
                        }
                    }

                    // Add the table to the document
                    document.Add(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to export data to PDF: {ex.Message}");
                }
                finally
                {
                    document.Close();
                }

                MessageBox.Show("PDF file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    // Override OnStartPage to add the header
    public override void OnStartPage(PdfWriter writer, Document document)
    {
        // Use the passed header paragraph
        if (_headerParagraph != null)
        {
            document.Add(_headerParagraph);
        }
    }

    // Override OnEndPage to add the footer
    public override void OnEndPage(PdfWriter writer, Document document)
    {
        // Footer
        Font footerFont = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL);
        PdfPTable footerTable = new PdfPTable(1)
        {
            TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin
        };
        PdfPCell cell = new PdfPCell(new Phrase($"Page {writer.PageNumber}", footerFont))
        {
            Border = Rectangle.NO_BORDER,
            HorizontalAlignment = Element.ALIGN_RIGHT
        };
        footerTable.AddCell(cell);
        footerTable.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin - 10, writer.DirectContent);
    }
}
