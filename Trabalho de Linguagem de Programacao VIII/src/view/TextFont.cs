using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Locadora.src.view
{
    class TextFont
    {
        private static PrivateFontCollection privateFont = new PrivateFontCollection();

        private static void AddFont(string path)
        {
            bool fontExists = false;
            foreach (FontFamily ff in privateFont.Families)
            {
                if (ff.Name == path)
                {
                    fontExists = true;
                    break;
                }
            }

            if (!fontExists)
            {
                privateFont.AddFontFile(path);
            }
        }

        public static void LabelUseCustomFont(string path, int size, Label label)
        {
            AddFont(path);
            label.Font = new Font(privateFont.Families[0], size);
        }

        public static void ButtonUseCustomFont(string path, int size, Button button)
        {
            AddFont(path);
            button.Font = new Font(privateFont.Families[0], size);
        }
    }
}
