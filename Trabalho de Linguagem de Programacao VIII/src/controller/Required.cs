using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.src.view;
using System.Windows.Forms;

namespace Locadora.src.controller
{
    class Required
    {
        public static bool isCpfValid(String cpf)
        {
            
            cpf = cpf.Replace("-", "").Replace(".", "");

            if (cpf.Length != 11 || cpf.Distinct().Count() == 1) return false;

            int[] weights = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 1; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * weights[i];
            }
            sum = (sum * 10) % 11;

            if (sum == 10 || sum == 11) sum = 0;
            if (!(sum == int.Parse(cpf[10].ToString()))) return false;

            sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * weights[i];
            }
            sum = (sum * 10) % 11;

            if (!(sum == int.Parse(cpf[10].ToString()))) return false;

            return true;
        }

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

                    if (textBox.Name == "txt_cpf" && !Required.isCpfValid(textBox.Text))
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

            PopUp.PopUpMessage(text, "Permitido sometente numeros");
            e.Handled = true;
            return false;
        }

    }
}
