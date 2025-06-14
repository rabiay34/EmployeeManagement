using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagement.Utilities
{
    public class ImageManipualtions
    {

        //byte[];

        public static byte[] GetPhoto(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);

            return ms.GetBuffer();

        }

        public static Image PutPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

    }
}
