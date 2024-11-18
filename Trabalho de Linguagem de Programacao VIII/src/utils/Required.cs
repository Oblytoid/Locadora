using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.src.view;
using System.Windows.Forms;
using Locadora.src.utils;

namespace Locadora.src.controller
{
    class Required
    {

        public static bool CheckRequiredField( params object[] obj)
        {
            bool allFieldIsOk = true;

            foreach (object field in obj)
            {

                if (!(field is TextBox) && !(field is ComboBox)) {
                    
                    continue;
                }

                if (field is TextBox)
                {
                    TextBox textBox = field as TextBox;

                    if (textBox.Name == "txt_cpf" && !Validators.isCpfValid(textBox.Text))
                    {
                        PopUp.PopUpMessage(textBox,"Cpf Invalido!!");
                        allFieldIsOk = false;
                    }

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

        public static bool onlyNumber(KeyPressEventArgs e, TextBox text)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }

            PopUp.PopUpMessage(text, "Permitido somente numeros");
            e.Handled = true;
            return false;
        }

    }
}
