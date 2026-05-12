using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Jogador
    {
        public string Nome { get; protected set; }
        public string Time { get; protected set; }
        public string Idade { get; protected set; } = "0";

        public virtual string Imagem()
        {
            return @"../../IMG/generic.jpg";
        }

    }

    class Bruno : Jogador
    {
        public Bruno()
        {
            Nome = "Bruno Henrique";
            Time = "Flamengo";
            Idade = "35";
        }

        public override string Imagem()
        {
            return @"../../IMG/brunohenrique.jpg";
        }
    }

    class Yuri : Jogador
    {
        public Yuri()
        {
            Nome = "Yuri Alberto";
            Time = "Corinthians";
            Idade = "25";
        }

        public override string Imagem()
        {
            return @"../../IMG/yurialberto.jpg";
        }

    }

    class Veiga : Jogador
    {
        public Veiga()
        {
            Nome = "Raphael Veiga";
            Time = "Palmeiras";
            Idade = "30";
        }

        public override string Imagem()
        {
            return @"../../IMG/veiga.jpg";
        }
    }

    class Moura : Jogador
    {
        public Moura()
        {
            Nome = "Lucas Moura";
            Time = "São Paulo";
            Idade = "33";
        }

        public override string Imagem()
        {
            return @"../../IMG/moura.jpg";
        }
    }

    class Neymar : Jogador
    {
        public Neymar()
        {
            Nome = "Neymar Jr";
            Time = "Santos";
            Idade = "34";
        }

        public override string Imagem()
        {
            return @"../../IMG/neymar.jpg";
        }
    }
}
