using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace forms1
{
    public class Usuario
    {
        private int _id;
        private string _senha;
        private string _nome;
        private string _telefone;
        private string _email;
        private string _cpf;
        private string _atendimento;
        private string _sugestao;

        public Usuario (int id,
                        string nome,
                        string senha,
                        string telefone,
                        string email,
                        string cpf,
                        string atendimento, 
                        string sugestao)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Atendimento = atendimento;
            Sugestao = sugestao;
        }


        // Propriedades
        // set = atribui o valor
        // get = retorna o valor

        public int Id
        {
            set
            {
                _id = value;
            }
            get { return _id; }
        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Nome está vazio!");
                _nome = value;
            }
            get { return _nome; }
        }
        public string Senha
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Senha está vazio!");
                _senha = value;
            }
            get { return _senha; }
        }
        public string Telefone
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Telefone está vazio!");
                _telefone = value;
            }
            get { return _telefone; }
        }

        public string Email
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Email está vazio!");
                _email = value;
            }
            get { return _email; }
        }

        public string Cpf
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo CPF está vazio!");
                _cpf = value;
            }
            get { return _cpf; }
        }
        public string Atendimento
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Atendimento está vazio!");
                _atendimento = value;
            }
            get { return _atendimento; }
        }
        public string Sugestao
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Sugestão está vazio!");
                _sugestao = value;
            }
            get { return _sugestao; }
        }
    }
}
