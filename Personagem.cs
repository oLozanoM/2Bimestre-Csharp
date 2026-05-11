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
        public virtual int Idade { get; protected set; } = 0;

        public virtual string Imagem()
        {
            return @"../../IMG/generic.jpg";
        }

    }

    class Nino : Jogador
    {
        public Nino()
        {
            Nome = "Nino Nakano";
            Time = "Cozinhar";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/ninobrr.jpg";
        }
    }

    class Miku : Jogador
    {
        public Miku()
        {
            Nome = "Miku Nakano";
            Time = "Ouvir Música";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/mikubrr.jpg";
        }
    }

    class Yotsuba : Jogador
    {
        public Yotsuba()
        {
            Nome = "Yotsuba Nakano";
            Time = "Praticar Esportes";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/yotsubabrr.jpg";
        }
    }

    class Itsuki : Jogador
    {
        public Itsuki()
        {
            Nome = "Itsuki Nakano";
            Time = "Ler";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/itsukibrr.jpg";
        }
    }

    class Ichika : Jogador
    {
        public Ichika()
        {
            Nome = "Ichika Nakano";
            Time = "Atuar";
            Idade = 26;
        }

        public override string Imagem()
        {
            return @"../../IMG/ichikabrr.jpg";
        }
    }
}
