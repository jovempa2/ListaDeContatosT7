using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT7
{
    internal class Contato
    {
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        // Propriedades (get e set)
        // é um controle de acesso ás variáveis. */
        public string Nome
        {
            get
            {
                return primeiroNome;
            }
            set
            { 
                primeiroNome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            //get = leitura 
            get
            {
                return telefone;
                //set = escrita
            }
            set
            {
                if (value.Length == 11)
                    telefone = value;

                else
                {
                    //País-Cidade-Telefone, ex: +55-11-97
                    telefone = "(00)-00000-0000";
                }
            }
        }
            //O método que tem o mesmo nome da clase
            //e não retorna nada, é chamado CONSTRUTOR
            // DA CLASSE.

            public Contato()
            {
            Nome = "José";
            Sobrenome = "Da Silva";
            Telefone = "(11)-99999-9999";

        }
        public Contato(string nome, string sobrenome, string telefone)
        {
            
            primeiroNome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        // Sobrescrever o método ToString()
        // "polimorfismo".

        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += string.Format("+{0} {1}-{2}", 
                Telefone.Substring(0, 2),
                Telefone.Substring(2, 5),
                Telefone.Substring(7, 4));
            return saida;
        }
    }
    }


         

                 

    
