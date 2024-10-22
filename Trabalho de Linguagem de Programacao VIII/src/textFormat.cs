using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_Linguagem_de_Programacao_VIII.src
{
    class textFormat
    {
        public static String cpfFormat(String cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            Console.WriteLine(cpf);
            if (cpf.Length > 11)
            {
                cpf = cpf.Substring(0, 11); // Limita o comprimento a 11 dígitos
            }

            if (cpf.Length <= 3) return cpf;
            if (cpf.Length <= 6) return $"{cpf.Substring(0, 3)}.{cpf.Substring(3)}";
            if (cpf.Length <= 9) return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6)}";
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
        }

        public static String telFormat(String telefone)
        {
            telefone = telefone.Replace(".", "").Replace("(", "").Replace(")", "").Replace(" ","").Replace("-", "");
            Console.WriteLine(telefone);

            if (telefone.Length > 0){
                if (telefone.Length > 11) telefone = telefone.Substring(0, 11);
            
               
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
