using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Linguagem_de_Programacao_VIII.src.view
{
    class PopUp
    {
        private static Dictionary<object,ToolTip> toolTips = new Dictionary<object, ToolTip>();
        private const int TIME = 2000;

        public static void PopUpMessage(Object obj, String message = "Campo obrigatorio!!")
        {
            if (!toolTips.ContainsKey(obj))
            {
                toolTips[obj] = new ToolTip();
            }

            if(obj is TextBox)
            {
                TextBox contr = obj as TextBox;
                toolTips[obj].Show(message, contr, 0, 20, TIME);
            }

            if (obj is ComboBox)
            {
                ComboBox contr = obj as ComboBox;
                toolTips[obj].Show(message, contr, 0, 20, TIME);
            } 
        }
    }
}
