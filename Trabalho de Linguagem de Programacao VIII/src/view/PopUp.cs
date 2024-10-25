using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.src.view
{
    class PopUp
    {
        private static Dictionary<object,ToolTip> toolTips = new Dictionary<object, ToolTip>();
        private const int TIME = 2000;

        public static void PopUpMessage(Object obj, String message = "Campo obrigatorio!!")
        {
            const int TIME = 3000;

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
