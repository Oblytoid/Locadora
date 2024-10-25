using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    public class User
    {
        private String cpf;
        private String nome;
        private String sobrenome;
        private String telefone;
        private String endereco;
        private String email;
        private String dataNascimento;

        public User(String cpf, String nome, String sobrenome, String telefone, String endereco, String email, String dataNascimento)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.email = email;
            this.dataNascimento = dataNascimento;
        }
        
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public String DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

    }
}
