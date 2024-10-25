using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Trabalho_de_Linguagem_de_Programacao_VIII.src.model
{
    class dataBase
    {
        
        //Como funciona (caminho; Segurança do acesso ao banco de dados; nome do banco de dados)
        //@"Data Source=LABHW-08; integrated security=SSPI;initial catalog=Locadora"
        private const String SQL = @"Data Source=DESKTOP-FQKS1SS\SQLEXPRESS; integrated security=SSPI;initial catalog=Locadora";
        SqlConnection connection = new SqlConnection(SQL);
        

        public static void save()
        {

        }
    }
}
