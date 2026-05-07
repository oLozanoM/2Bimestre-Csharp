using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace POO
{
    class Apresentacao : Form
    {
        // criar um objeto do automovel
        Quintuplas Obj01Nino = new Quintuplas();
        Quintuplas Obj01Miku = new Quintuplas();
        Quintuplas Obj01Yotsuba = new Quintuplas();
        Quintuplas Obj01Itsuki = new Quintuplas();
        Quintuplas Obj01Ichika = new Quintuplas();

        // Objeto
        PictureBox img = new PictureBox();
        Label txtFav = new Label();
        Label txtIdade = new Label();
        Label txtNome = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btobj04 = new Button();
        Button btobj05 = new Button();




        // toda classe tem um construtor
        public Apresentacao()
        {
            this.Text = "Titulo ";
            this.Size = new Size(600, 600);
            btobj01.Text = " 1 OPÇAO ";
            btobj01.Location = new Point(50, 50);
            btobj01.Click += Ichika;

            btobj02.Text = " 2 OPÇAO ";
            btobj02.Location = new Point(150, 50);
            btobj02.Click += Nino;

            btobj03.Text = " 3 OPÇAO ";
            btobj03.Location = new Point(250, 50);
            btobj03.Click += Miku;

            btobj04.Text = " 4 OPÇAO ";
            btobj04.Location = new Point(350, 50);
            btobj04.Click += Yotsuba;

            btobj05.Text = " 5 OPÇAO ";
            btobj05.Location = new Point(450, 50);
            btobj05.Click += Itsuki;



            // Control[] controles = new Control[] { txtMarca, btobj01 }; 
            //this.Controls.Add(btobj01);
            this.Controls.AddRange(new Control[] {btobj01, img, btobj02, btobj03, btobj04, btobj05, txtFav,txtIdade, txtNome });

        }

            //MessageBox.Show("Metodo de Evento");
            // fazer apresentação da carro01
            //carr01.SetMarca("Fiat");
            // this.txtMarca.Text = " Marca : " + carr01.GetMarca();
            // COLOCAR IMAGEM
            //img.Image = Image.FromFile(@"C:\Users\LabInfo\source\repos\'Emerson - Rocha'\POO_\IMG\uno.jpg");
            //img.SizeMode = PictureBoxSizeMode.AutoSize;
            //img.Width = 200;
            //img.Height = 150;
            // this.img.Location = new Point(100, 200);



        private void Nino(object sender, EventArgs e)
        {
            Quintuplas Obj01Nino = new Quintuplas("Nino", "26 anos");

            Obj01Nino.Nome = "Nino Nakano";
            Obj01Nino.Idade = 26;
            Obj01Nino.Fav = "Cozinhar";
            txtNome.Text = " Nome : " + Obj01Nino.Nome;
            txtIdade.Text = " Idade : " + Obj01Nino.Idade;
            txtFav.Text = " Coisa Favorita : " + Obj01Nino.Fav;
            this.txtNome.Location = new Point(100, 150);
            this.txtIdade.Location = new Point(100, 190);
            this.txtFav.Location = new Point(100, 230);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);
            img.Image = Image.FromFile(@"C:\Users\llmar\source\repos\POO_-master\POO_-master\IMG\ninobrr.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(100, 250);
        }
        private void Miku(object sender, EventArgs e)
        {
            Quintuplas Obj01Miku = new Quintuplas("Miku", "26 anos");
            Obj01Miku.Nome = "Miku Nakano";
            Obj01Miku.Idade = 26;
            Obj01Miku.Fav = "Ouvir Música";
            txtNome.Text = " Nome : " + Obj01Miku.Nome;
            txtIdade.Text = " Idade : " + Obj01Miku.Idade;
            txtFav.Text = " Coisa Favorita : " + Obj01Miku.Fav;
            this.txtNome.Location = new Point(100, 150);
            this.txtIdade.Location = new Point(100, 190);
            this.txtFav.Location = new Point(100, 230);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);
            img.Image = Image.FromFile(@"C:\Users\llmar\source\repos\POO_-master\POO_-master\IMG\mikubrr.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(100, 250);
        }
        private void Yotsuba(object sender, EventArgs e)
        {
            Quintuplas Obj01Yotsuba = new Quintuplas("Yotsuba", "26 anos");

            Obj01Yotsuba.Nome = "Yotsuba Nakano";
            Obj01Yotsuba.Idade = 26;
            Obj01Yotsuba.Fav = "Praticar Esportes";
            txtNome.Text = " Nome : " + Obj01Yotsuba.Nome;
            txtIdade.Text = " Idade : " + Obj01Yotsuba.Idade;
            txtFav.Text = " Coisa Favorita : " + Obj01Yotsuba.Fav;
            this.txtNome.Location = new Point(100, 150);
            this.txtIdade.Location = new Point(100, 190);
            this.txtFav.Location = new Point(100, 230);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);
            img.Image = Image.FromFile(@"C:\Users\llmar\source\repos\POO_-master\POO_-master\IMG\yotsubabrr.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(100, 250);

        }
        private void Itsuki(object sender, EventArgs e)
        {
            Quintuplas Obj01Itsuki = new Quintuplas("Itsuki", "26 anos");
 
            Obj01Itsuki.Nome = "Itsuki Nakano";
            Obj01Itsuki.Idade = 26;
            Obj01Itsuki.Fav = "Ler";
            txtNome.Text = " Nome : " + Obj01Itsuki.Nome;
            txtIdade.Text = " Idade : " + Obj01Itsuki.Idade;
            txtFav.Text = " Coisa Favorita : " + Obj01Itsuki.Fav;
            this.txtNome.Location = new Point(100, 150);
            this.txtIdade.Location = new Point(100, 190);
            this.txtFav.Location = new Point(100, 230);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);
            img.Image = Image.FromFile(@"C:\Users\llmar\source\repos\POO_-master\POO_-master\IMG\itsukibrr.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(100, 250);

        }
        private void Ichika(object sender, EventArgs e)
        {
            Quintuplas Obj01Ichika = new Quintuplas("Ichika", "26 anos");
            Obj01Ichika.Nome = "Ichika Nakano";
            Obj01Ichika.Idade = 26;
            Obj01Ichika.Fav = "Atuar";
            txtNome.Text = " Nome : " + Obj01Ichika.Nome;
            txtIdade.Text = " Idade : " + Obj01Ichika.Idade;
            txtFav.Text = " Coisa Favorita : " + Obj01Ichika.Fav;
            this.txtNome.Location = new Point(100, 150);
            this.txtIdade.Location = new Point(100, 190);
            this.txtFav.Location = new Point(100, 230);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);
            img.Image = Image.FromFile(@"C:\Users\llmar\source\repos\POO_-master\POO_-master\IMG\ichikabrr.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(100, 250);
        }
    }
}