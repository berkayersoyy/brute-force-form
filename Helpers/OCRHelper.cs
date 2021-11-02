using IronOcr;


namespace Helpers
{
    public static class OCRHelper
    {
        public static string Recognize(string path)
        {
            var ocr = new IronTesseract();
            using (var input = new OcrInput())
            {
                var tempPath = @"C:\Users\BERKAY\Desktop\2.png";
                input.AddImage(tempPath);
                var result = ocr.Read(input);
                return result.Text;
            }
        }
    }
}