using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.utils
{
    class Validators
    {
        public static bool isCpfValid(String cpf)
        {
            return true;
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

    }
}
