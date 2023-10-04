using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1
{
    public class Usuario
    {
        private string _id;
        private string _name;
        private string _telefone;
        private string _email;
        private string _cpf;
        private string _atendimento;
        private string _sugestao;

        public Usuario (string name,
                        string telefone,
                        string cpf,
                        string atendimento, 
                        string sugestao) {

            Name = name;
            Telefone = telefone;
            Cpf = cpf;
            Atendimento = atendimento;
            Sugestao = sugestao;

        }

        // Propriedades
        public string Name
        {
             set { this.Name = value; }
             get { return this._name; }
        }
        public string Telefone
        {
            set { this.Telefone = value; }
            get { return this._telefone; }
        }
        public string Cpf
        {
            set { this.Cpf = value; }
            get { return this._cpf; }
        }
        public string Atendimento
        {
            set { this.Atendimento = value; }
            get { return this._atendimento; }
        }
        public string Sugestao
        {
            set { this.Sugestao = value; }
            get { return this._sugestao; }
        }

    }
}
