using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;
using System.IO;

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
        Label Titulo = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btobj04 = new Button();
        Button btobj05 = new Button();

        //Painel
        Panel painel = new Panel();
        
        public Apresentacao()
        {
            this.Text = "atividade 2bim ";
            this.Size = new Size(900, 600);

            painel.BackColor = Color.SkyBlue;
            painel.Dock = DockStyle.Left;
            painel.Width = 300;

            Titulo.Text = "Escolha a personagem de sua preferência";
            Titulo.Size = new Size(250, 45);
            Titulo.Font = new Font("Arial", 14);
            Titulo.Location = new Point(50, 50);

            btobj01.Text = " Ichika ";
            btobj01.AutoSize = true;
            btobj01.Click += Ichika;

            btobj02.Text = " Nino ";
            btobj02.AutoSize = true;
            btobj02.Click += Nino;

            btobj03.Text = " Miku ";
            btobj03.AutoSize = true;
            btobj03.Click += Miku;

            btobj04.Text = " Yotsuba ";
            btobj04.AutoSize = true;
            btobj04.Click += Yotsuba;

            btobj05.Text = " Itsuki ";
            btobj05.AutoSize = true;
            btobj05.Click += Itsuki;

            Titulo.Location = new Point(20, 20);
            btobj01.Location = new Point(20, 80);
            btobj02.Location = new Point(20, 130);
            btobj03.Location = new Point(20, 180);
            btobj04.Location = new Point(20, 230);
            btobj05.Location = new Point(20, 280);

            Titulo.BackColor = Color.SkyBlue;
            btobj01.BackColor = Color.Transparent;
            btobj02.BackColor = Color.Transparent;
            btobj03.BackColor = Color.Transparent;
            btobj04.BackColor = Color.Transparent;
            btobj05.BackColor = Color.Transparent;

            painel.Controls.Add(Titulo);
            painel.Controls.Add(btobj01);
            painel.Controls.Add(btobj02);
            painel.Controls.Add(btobj03);
            painel.Controls.Add(btobj04);
            painel.Controls.Add(btobj05);

            this.Controls.AddRange(new Control[] {painel, img, txtFav, txtIdade, txtNome});

        }

        private void Nino(object sender, EventArgs e)
        {
            Quintuplas Obj01Nino = new Quintuplas("Nino", "26 anos");

            Obj01Nino.Nome = "Nino Nakano";
            Obj01Nino.Idade = 26;
            Obj01Nino.Fav = "Cozinhar";

            txtNome.Text = " Nome : " + Obj01Nino.Nome;
            txtIdade.Text = " Idade : " + Obj01Nino.Idade;
            txtFav.Text = " Coisa Favorita : " + Obj01Nino.Fav;

            this.txtNome.Location = new Point(500, 50);
            this.txtIdade.Location = new Point(500, 90);
            this.txtFav.Location = new Point(500, 130);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            string imgPath = Path.Combine(Application.StartupPath, @"..\..\IMG\ninobrr.jpg");
            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show($"Arquivo de imagem não encontrado:\n{imgPath}", "Arquivo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(480, 180);
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

            this.txtNome.Location = new Point(500, 50);
            this.txtIdade.Location = new Point(500, 90);
            this.txtFav.Location = new Point(500, 130);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            string imgPath = Path.Combine(Application.StartupPath, @"..\..\IMG\mikubrr.jpg");
            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show($"Arquivo de imagem não encontrado:\n{imgPath}", "Arquivo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(480, 180);
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

            this.txtNome.Location = new Point(500, 50);
            this.txtIdade.Location = new Point(500, 90);
            this.txtFav.Location = new Point(500, 130);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            string imgPath = Path.Combine(Application.StartupPath, @"..\..\IMG\yotsubabrr.jpg");
            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show($"Arquivo de imagem não encontrado:\n{imgPath}", "Arquivo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(480, 180);
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

            this.txtNome.Location = new Point(500, 50);
            this.txtIdade.Location = new Point(500, 90);
            this.txtFav.Location = new Point(500, 130);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            string imgPath = Path.Combine(Application.StartupPath, @"..\..\IMG\itsukibrr.jpg");
            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show($"Arquivo de imagem não encontrado:\n{imgPath}", "Arquivo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(480, 180);
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

            this.txtNome.Location = new Point(500, 50);
            this.txtIdade.Location = new Point(500, 90);
            this.txtFav.Location = new Point(500, 130);
            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            string imgPath = Path.Combine(Application.StartupPath, @"..\..\IMG\ichikabrr.jpg");
            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show($"Arquivo de imagem não encontrado:\n{imgPath}", "Arquivo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            this.img.Location = new Point(480, 180);
        }
    }
}