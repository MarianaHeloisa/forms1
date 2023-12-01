using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1
{
    public class Endereco
    {
        private int _id;
        private string _nome;
        private string _cep;
        private string _endereço;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;

        public Endereco(int id,
                        string nome,
                        string cep,
                        string endereço,
                        string numero,
                        string bairro,
                        string cidade,
                        string estado)
        {
            Id = id;
            Nome = nome;
            Cep = cep;
            Endereço = endereço;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
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
        public string Cep
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo CEP está vazio!");
                _cep = value;
            }
            get { return _cep; }
        }
        public string Endereço
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Endereço está vazio!");
                _endereço = value;
            }
            get { return _endereço; }
        }

        public string Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Numero está vazio!");
                _numero = value;
            }
            get { return _numero; }
        }

        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Bairro está vazio!");
                _bairro = value;
            }
            get { return _bairro; }
        }
        public string Cidade
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Cidade está vazio!");
                _cidade = value;
            }
            get { return _cidade; }
        }
        public string Estado
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Campo Estado está vazio!");
                _estado = value;
            }
            get { return _estado; }
        }
    }
}
