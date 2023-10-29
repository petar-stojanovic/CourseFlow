using CourseFlow.Data;
using CourseFlow.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;


namespace CourseFlow.Services;

public class CertificateGenerator
{
    private readonly DataContext _context;

    public CertificateGenerator(DataContext context)
    {
        _context = context;
    }

    public byte[] GenerateCertificate(UserTakesCourse userTakesCourse)
    {
        Course course = _context.Courses.FirstOrDefault(c => c.Id == userTakesCourse.CourseId);
        User user = _context.Users.FirstOrDefault(u => u.Id == userTakesCourse.UserId);


        using (MemoryStream ms = new MemoryStream())
        {
            Document document = new Document(PageSize.A4, 25, 25, 20, 20);
            PdfWriter writer = PdfWriter.GetInstance(document, ms);
            document.Open();

            Paragraph paragraph = new Paragraph("Certificate of Completion",
                new Font(new Font(Font.FontFamily.COURIER, 32, Font.BOLDITALIC)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);

            var image = Image.GetInstance(course.Thumbnail);
            float aspectRatio = image.Height / image.Width;
            float imageWidth = 420f;
            image.ScaleAbsolute(imageWidth, imageWidth * aspectRatio);
            image.Alignment = Element.ALIGN_CENTER;
            document.Add(image);

            paragraph = new Paragraph("This is to certify that",
                new Font(new Font(Font.FontFamily.COURIER, 16, Font.ITALIC)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);


            paragraph = new Paragraph(user.Username, new Font(new Font(Font.FontFamily.COURIER, 28, Font.BOLDITALIC)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);


            paragraph = new Paragraph("has completed the course",
                new Font(new Font(Font.FontFamily.COURIER, 16, Font.ITALIC)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);

            paragraph = new Paragraph(course.Title,
                new Font(new Font(Font.FontFamily.COURIER, 30, Font.BOLDITALIC)));
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);

            document.Add(new Chunk("\n"));

            paragraph = new Paragraph(userTakesCourse.StartDate.ToString(),
                new Font(new Font(Font.FontFamily.COURIER, 25, Font.ITALIC)));
            paragraph.Alignment = Element.ALIGN_LEFT;
            document.Add(paragraph);

            paragraph = new Paragraph(userTakesCourse.EndDate.ToString(),
                new Font(new Font(Font.FontFamily.COURIER, 25, Font.ITALIC)));
            paragraph.Alignment = Element.ALIGN_RIGHT;
            document.Add(paragraph);


            document.Close();
            writer.Close();
            return ms.ToArray();
        }
    }
}