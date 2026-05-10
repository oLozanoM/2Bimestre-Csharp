using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Personagem
    {
        public string Nome { get; protected set; }
        public string Fav { get; protected set; }
        public virtual int Idade { get; protected set; } = 0;

        public virtual string Imagem()
        {
            return @"../../IMG/generic.jpg";
        }

    }

    class Nino : Personagem
    {
        public Nino()
        {
            Nome = "Nino Nakano";
            Fav = "Cozinhar";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/ninobrr.jpg";
        }
    }

    class Miku : Personagem
    {
        public Miku()
        {
            Nome = "Miku Nakano";
            Fav = "Ouvir Música";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/mikubrr.jpg";
        }
    }

    class Yotsuba : Personagem
    {
        public Yotsuba()
        {
            Nome = "Yotsuba Nakano";
            Fav = "Praticar Esportes";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/yotsubabrr.jpg";
        }
    }

    class Itsuki : Personagem
    {
        public Itsuki()
        {
            Nome = "Itsuki Nakano";
            Fav = "Ler";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/itsukibrr.jpg";
        }
    }

    class Ichika : Personagem
    {
        public Ichika()
        {
            Nome = "Ichika Nakano";
            Fav = "Atuar";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/ichikabrr.jpg";
        }
    }
}
