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

        private void MostrarPersonagem(Personagem p)
        {
            txtNome.Text = "Nome: " + p.Nome;
            txtIdade.Text = "Idade: " + p.Idade;
            txtFav.Text = "Favorito: " + p.Fav;

            txtNome.Location = new Point(500, 50);
            txtIdade.Location = new Point(500, 90);
            txtFav.Location = new Point(500, 130);

            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            string imgPath = Path.Combine(Application.StartupPath, p.Imagem());

            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show("Imagem não encontrada!");
            }

            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.Width = 200;
            img.Height = 300;
            img.Location = new Point(480, 180);
        }

        private void Ichika (object sender, EventArgs e)
        {
            MostrarPersonagem(new Ichika());
        }

        private void Nino (object sender, EventArgs e)
        {
            MostrarPersonagem(new Nino());
        }

        private void Miku (object sender, EventArgs e)
        {
            MostrarPersonagem(new Miku());
        }

        private void Yotsuba (object sender, EventArgs e)
        {
            MostrarPersonagem(new Yotsuba());
        }

        private void Itsuki(object sender, EventArgs e)
        {
            MostrarPersonagem(new Itsuki());
        }

    }
}