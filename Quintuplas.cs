using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Quintuplas 
    {

        
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Fav { get; set; }
        public string imagen { get; set; }




        public Quintuplas(string nome, int idade, string fav)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Fav = fav;
        }

        public Quintuplas()
        {
        }

        public Quintuplas(string v1, string v2)
        {
        }
    }

    
}
