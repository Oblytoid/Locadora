using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.src.model
{
    class TextFormat
    {
        public static String cpfFormat(String cpf, bool staySave =  false)
        {
            cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "");


            if (cpf.Length > 11)
            {
                cpf = cpf.Substring(0, 11); // Limita o comprimento a 11 dígitos
            }

            if (staySave) return cpf;

            if (cpf.Length <= 3) return cpf;
            if (cpf.Length <= 6) return $"{cpf.Substring(0, 3)}.{cpf.Substring(3)}";
            if (cpf.Length <= 9) return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6)}";
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
        }

        public static String telFormat(String telefone, bool staySave = false)
        {
            telefone = telefone.Replace(".", "").Replace("(", "").Replace(")", "").Replace(" ","").Replace("-", "");

            if (telefone.Length > 0){
                if (telefone.Length > 11) telefone = telefone.Substring(0, 11);
                if (staySave) return telefone;

                if (telefone.Length <= 2) return $"({telefone}";
                if (telefone.Length <= 6) return $"({telefone.Substring(0, 2)}) {telefone.Substring(2)}";
                if (telefone.Length <= 10) return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)}-{telefone.Substring(6)}";

                // Para números de telefone celular, que têm 11 dígitos:
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7)}";
            }
            return telefone;
        }

        
    }
}
