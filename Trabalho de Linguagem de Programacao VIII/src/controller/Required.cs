using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Trabalho_de_Linguagem_de_Programacao_VIII.src.view;
using System.Windows.Forms;

namespace Trabalho_de_Linguagem_de_Programacao_VIII.src.controller
{
    class Required
    {

        public static bool CheckRequiredField( params object[] obj)
        {
            bool allFieldIsOk = true;

            foreach (object field in obj)
            {

                if (!(field is TextBox) && !(field is ComboBox)) {
                    allFieldIsOk = false;
                    continue;
                }

                if (field is TextBox)
                {
                    TextBox textBox = field as TextBox;
                    if (String.IsNullOrEmpty(textBox.Text.Trim()))
                    {
                        PopUp.PopUpMessage(textBox);
                        allFieldIsOk = false;

                    }
                }

                if (field is ComboBox)
                {
                    ComboBox comboBox = field as ComboBox;
                    if (String.IsNullOrEmpty(comboBox.Text.Trim()))
                    {
                        PopUp.PopUpMessage(comboBox);
                        allFieldIsOk = false;
                    }
                }
            }
            return allFieldIsOk;
        }
    }
}
