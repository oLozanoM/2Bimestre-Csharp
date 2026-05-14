using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Tenis
    {
        public string Nome { get; protected set; }

        public string Cor { get; protected set; }
        public string Marca { get; protected set; }
        public virtual string Desc { get; protected set; } = "tenis generico";

        public virtual string Imagem()
        {
            return @"../../IMG/generic.jpg";
        }

    }

    class Star : Tenis
    {
        public Star()
        {
            Nome = "Superstar";
            Cor = "Core Black / Cloud White / Core Black";
            Marca = "Adidas";
            Desc = "O Adidas Superstar é um tênis clássico da Adidas conhecido pelo seu design icônico com a biqueira" +
            " de borracha em formato de concha (“shell toe”) Confortável e versátil, combina estilo urbano com durabilidade, " +
            "sendo uma das silhuetas mais famosas da marca desde os anos 70.";
        }

        public override string Imagem()
        {
            return @"../../IMG/superstar.jpg";
        }
    }

    class Campus : Tenis
    {
        public Campus()
        {
            Nome = "Campus";
            Cor = "Core Black / Cloud White / Off White";
            Marca = "Adidas";
            Desc = "O Adidas Campus é um tênis clássico da Adidas que se destaca pelo visual casual e atemporal. Feito geralmente em camurça," +
            " possui solado resistente e design simples que combina conforto e estilo urbano, sendo muito popular na moda streetwear e no dia a dia.";
        }

        public override string Imagem()
        {
            return @"../../IMG/campus.jpg";
        }

    }

    class Samba : Tenis
    {
        public Samba()
        {
            Nome = "Samba OG";
            Cor = "Cloud White / Core Black / Clear Granite";
            Marca = "Adidas";
            Desc = "O Adidas Samba é um dos modelos mais icônicos da Adidas, reconhecido pelo visual retrô e elegante. Originalmente criado para" +
            " o futebol, o tênis combina couro, detalhes em camurça e solado de borracha, oferecendo conforto, durabilidade e um estilo versátil " +
            "que combina com diferentes ocasiões.";
        }

        public override string Imagem()
        {
            return @"../../IMG/samba.jpg";
        }
    }

    class Forum : Tenis
    {
        public Forum()
        {
            Nome = "Forum Low CL";
            Cor = "Off White / Dark Blue / Dark Blue";
            Marca = "Adidas";
            Desc = "O Adidas Forum Low CL é um tênis da Adidas inspirado no basquete retrô dos anos 80, com visual clássico e detalhes modernos." +
            " Possui cabedal resistente, solado confortável e o tradicional design robusto da linha Forum, sendo uma opção estilosa para o uso casual" +
            " e streetwear.";
        }

        public override string Imagem()
        {
            return @"../../IMG/forum.jpg";
        }
    }

    class Forum2000 : Tenis
    {
        public Forum2000()
        {
            Nome = "Forum 2000";
            Cor = "Wonder Sage / Off White / Alumina";
            Marca = "Adidas";
            Desc = "O Adidas Forum2000 é um tênis da Adidas que mistura o estilo retrô do basquete com um visual moderno e robusto." +
            " Com design inspirado nos anos 2000, ele traz solado volumoso, muito conforto e detalhes marcantes, sendo ideal para quem " +
            "busca um estilo urbano e diferenciado no dia a dia.";
        }

        public override string Imagem()
        {
            return @"../../IMG/forum2000.jpg";
        }
    }

    class Adi2000 : Tenis
    {
        public Adi2000()
        {
            Nome = "Adi 2000";
            Cor = "Cloud White / Core Black / Chalk White";
            Marca = "Adidas";
            Desc = "O Adidas Adi2000 é um tênis da Adidas inspirado na estética skate e streetwear dos anos 2000. Com visual robusto," +
            " solado confortável e detalhes marcantes, o modelo combina estilo retrô com atitude moderna, sendo ideal para compor looks" +
            " urbanos e casuais.";
        }

        public override string Imagem()
        {
            return @"../../IMG/adi2000.jpg";
        }
    }
}
