using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Mangas
    {
        public string Nome { get; protected set; }

        public string Lançamento { get; protected set; }
        public string Editora { get; protected set; }
        public virtual string Desc { get; protected set; } = "tenis generico";

        public virtual string Imagem()
        {
            return @"../../IMG/generic.jpg";
        }

    }

    class DBS : Mangas
    {
        public DBS()
        {
            Nome = "Dragon Ball Super";
            Lançamento = "2015";
            Editora = "Panini";
            Desc = "Continue a lendária jornada de Goku e dos Guerreiros Z em batalhas ainda mais épicas!" +
                " Dragon Ball Super traz novos universos, inimigos extremamente poderosos e transformações incríveis que ultrapassam todos os limites conhecidos.Com muita ação, humor e lutas eletrizantes." +
                " Este mangá é perfeito para fãs de aventura e combates intensos.";
        }

        public override string Imagem()
        {
            return @"../../IMG/Dbs.jpg";
        }
    }

    class SAO : Mangas
    {
        public SAO()
        {
            Nome = "Sword Art Online";
            Lançamento = "2010";
            Editora = "Panini";
            Desc = "Presos dentro de um jogo de realidade virtual mortal, Kirito e outros jogadores precisam sobreviver para escapar vivos." +
                " Sword Art Online mistura ação, romance e ficção científica em uma aventura emocionante dentro de mundos virtuais cheios de desafios, criaturas perigosas e batalhas inesquecíveis.";
        }

        public override string Imagem()
        {
            return @"../../IMG/SwordArtOnlineVol.1.jpg";
        }

    }

    class Frieren : Mangas
    {
        public Frieren()
        {
            Nome = "Sōsō no Frieren";
            Lançamento = "2020";
            Editora = "Panini";
            Desc = "Após derrotar o Rei Demônio, a elfa Frieren inicia uma nova jornada para compreender melhor os sentimentos humanos e o valor do tempo." +
                "Com uma narrativa emocionante, reflexiva e cheia de momentos tocantes, Frieren conquistou fãs no mundo inteiro por sua atmosfera única e personagens marcantes.";
        }

        public override string Imagem()
        {
            return @"../../IMG/frieren.jpg";
        }
    }

    class CSM : Mangas
    {
        public CSM()
        {
            Nome = "Chainsaw Man";
            Lançamento = "2018";
            Editora = "Panini";
            Desc = "Denji é um jovem caçador de demônios que, após um acontecimento inesperado, ganha o poder da motosserra demoníaca." +
                " Chainsaw Man entrega uma mistura intensa de ação brutal, humor ácido e momentos emocionantes, criando uma história imprevisível e cheia de adrenalina do começo ao fim.";
        }

        public override string Imagem()
        {
            return @"../../IMG/CSM.png";
        }
    }

    class REzero : Mangas
    {
        public REzero()
        {
            Nome = "RE:Zero";
            Lançamento = "2014";
            Editora = "Panini";
            Desc = "Subaru Natsuki é transportado para outro mundo e descobre um poder assustador:" +
                " voltar no tempo sempre que morre. Re: Zero combina fantasia, suspense e drama psicológico em uma trama cheia de mistérios, sofrimento e desenvolvimento profundo dos personagens.";
        }

        public override string Imagem()
        {
            return @"../../IMG/Rez.jpg";
        }
    }

    class Bleach : Mangas
    {
        public Bleach()
        {
            Nome = "Bleach";
            Lançamento = "2001";
            Editora = "Panini";
            Desc = "Ichigo Kurosaki sempre conseguiu ver espíritos, mas sua vida muda completamente ao receber os poderes de um Ceifador de Almas." +
                " Em Bleach, acompanhe batalhas épicas, espadas lendárias e confrontos sobrenaturais contra Hollows e outros inimigos poderosos em um dos maiores clássicos dos mangás shounen.";
        }

        public override string Imagem()
        {
            return @"../../IMG/Bleach.png";
        }
    }
}
