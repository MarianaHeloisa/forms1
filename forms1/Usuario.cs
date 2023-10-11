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
                        string email,
                        string cpf,
                        string atendimento, 
                        string sugestao)
        {

            Name = name;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Atendimento = atendimento;
            Sugestao = sugestao;
            

        }

        public Usuario(int id, string name,
                       string telefone,
                       string email,
                       string cpf,
                       string atendimento,
                       string sugestao)
                    
        {
            Id = Id;
            Name = name;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Atendimento = atendimento;
            Sugestao = sugestao;
            

        }

        // Propriedades
        // set = atribui o valor
        // get = retorna o valor

        public string Name
        {
             set { 
                if (string.IsNullOrEmpty (value))
                    throw new Exception ("Campo Nome está vazio!");
                
                
                this.Name = value;
            }
             get { return this._name; }
        }
        public string Telefone
        {
            set { 
                if(string.IsNullOrEmpty (value))
                    throw new Exception ("Campo Telefone está vazio!");
                
                
                this.Telefone = value; 
            }
            get { return this._telefone; }
        }

        public string Email
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo Email está vazio!");


                this.Email = value;
            }
            get { return this._email; 
            }
        }

        public string Cpf
        {
            set { 
                if(string.IsNullOrEmpty (value))
                    throw new Exception ("Campo Cpf está vazio!");
                
                
                this.Cpf = value; 
            }
            get { return this._cpf; 
            }
        }
        public string Atendimento
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo Atendimento está vazio");
                
                
                this.Atendimento = value;
            }
            get { return this._atendimento;
            }
        }
        public string Sugestao
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo Sugestão está vazio");
                
                this.Sugestao = value;
            }
            get { return this._sugestao; 
            }
        }

        public string Id
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo Id está vazio");


                this.Id = value;
            }
            get
            {
                return this._id;
                {

                }


            }

        }
    }
}
