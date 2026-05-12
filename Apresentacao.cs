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
            this.Text = "Jogadores brasileiros ";
            this.Size = new Size(900, 600);

            painel.BackColor = Color.DarkGreen;
            painel.Dock = DockStyle.Left;
            painel.Width = 300;

            Titulo.Text = "Escolha o jogador";
            Titulo.Location = new Point(50, 90);
            Titulo.Size = new Size(250,25);
            Titulo.Font = new Font("Arial", 16);
            Titulo.ForeColor = Color.White;
            
            btobj01.Text = " Bruno ";
            btobj01.AutoSize = true;
            btobj01.Click += Bruno;

            btobj02.Text = " Yuri ";
            btobj02.AutoSize = true;
            btobj02.Click += Yuri;

            btobj03.Text = " Veiga ";
            btobj03.AutoSize = true;
            btobj03.Click += Veiga;

            btobj04.Text = " Moura ";
            btobj04.AutoSize = true;
            btobj04.Click += Moura;

            btobj05.Text = " Neymar ";
            btobj05.AutoSize = true;
            btobj05.Click += Neymar;

            int x = 100;

            Titulo.Location = new Point(50, 10);
            btobj01.Location = new Point(x, 90);
            btobj02.Location = new Point(x, 170);
            btobj03.Location = new Point(x, 250);
            btobj04.Location = new Point(x, 330);
            btobj05.Location = new Point(95, 400);

            btobj01.Font = new Font("Arial", 12);
            btobj02.Font = new Font("Arial", 12);
            btobj03.Font = new Font("Arial", 12);
            btobj04.Font = new Font("Arial", 12);
            btobj05.Font = new Font("Arial", 12);

            
            btobj01.FlatAppearance.BorderSize = 2;
            
            btobj02.FlatAppearance.BorderSize = 2;

            btobj03.FlatAppearance.BorderSize = 2;

            btobj04.FlatAppearance.BorderSize = 2;

            btobj05.FlatAppearance.BorderSize = 2;

            Titulo.BackColor = Color.DarkGreen;

            btobj01.BackColor = Color.DarkGreen;
            btobj01.ForeColor = Color.White;

            btobj02.BackColor = Color.DarkGreen;
            btobj02.ForeColor = Color.White;

            btobj03.BackColor = Color.DarkGreen;
            btobj03.ForeColor = Color.White;

            btobj04.BackColor = Color.DarkGreen;
            btobj04.ForeColor = Color.White;

            btobj05.BackColor = Color.DarkGreen;
            btobj05.ForeColor = Color.White;

            painel.Controls.Add(Titulo);
            painel.Controls.Add(btobj01);
            painel.Controls.Add(btobj02);
            painel.Controls.Add(btobj03);
            painel.Controls.Add(btobj04);
            painel.Controls.Add(btobj05);

            this.Controls.AddRange(new Control[] {painel, img, txtFav, txtIdade, txtNome});

        }

        private void MostrarPersonagem(Jogador p)
        {
            txtNome.Text = "Nome: " + p.Nome;
            txtIdade.Text = "Idade: " + p.Idade;
            txtFav.Text = "Time: " + p.Time;

            txtNome.Location = new Point(475, 50);
            txtIdade.Location = new Point(475, 90);
            txtFav.Location = new Point(475, 130);

            txtNome.Size = new Size(300, 30);
            txtIdade.Size = new Size(300, 30);
            txtFav.Size = new Size(300, 30);

            txtFav.Font = new Font("Arial", 12);
            txtNome.Font = new Font("Arial", 12);
            txtIdade.Font = new Font("Arial", 12);

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

        private void Bruno (object sender, EventArgs e)
        {
            MostrarPersonagem(new Bruno());
        }

        private void Yuri (object sender, EventArgs e)
        {
            MostrarPersonagem(new Yuri());
        }

        private void Veiga (object sender, EventArgs e)
        {
            MostrarPersonagem(new Veiga());
        }

        private void Moura (object sender, EventArgs e)
        {
            MostrarPersonagem(new Moura());
        }

        private void Neymar (object sender, EventArgs e)
        {
            MostrarPersonagem(new Neymar());
        }

    }
}