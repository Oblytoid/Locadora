using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.services
{
    static class ImageConverter
    {
        public static Image ByteArrayToImagem(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                throw new ArgumentException("O array de bytes não pode ser nulo ou vazio.", nameof(byteArray));

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao converter byte array para imagem: {ex.Message}");
                throw;
            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "A imagem não pode ser nula.");

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    if (ImageFormat.Jpeg.Equals(image.RawFormat) ||
                        ImageFormat.Png.Equals(image.RawFormat) ||
                        ImageFormat.Bmp.Equals(image.RawFormat) ||
                        ImageFormat.Gif.Equals(image.RawFormat))
                    {
                        image.Save(ms, image.RawFormat);
                        return ms.ToArray();
                    }
                    else
                    {
                        throw new InvalidOperationException("Formato de imagem não suportado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao converter a imagem para byte array: {ex.Message}");
                throw;
            }
        }
    }
}
