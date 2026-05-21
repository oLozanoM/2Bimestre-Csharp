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

    class  Apresentacao : Form
    {
        PictureBox img = new PictureBox();

        Label txtDesc = new Label();
        Label txtLançamento = new Label();
        Label txtEditora = new Label();
        Label txtNome = new Label();
        Label Titulo = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btobj04 = new Button();
        Button btobj05 = new Button();
        Button btobj06 = new Button();

        Panel painel = new Panel();

        public Apresentacao()
        {
            this.Icon = new Icon(@"../../IMG/logo_comix_120.ico");
            this.Text = "Loja de Mangás";
            this.Size = new Size(1100, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Painel 
            painel.BackColor = Color.FromArgb(25, 25, 25);
            painel.Dock = DockStyle.Left;
            painel.Width = 280;

            // Título
            Titulo.Text = "Mangás";
            Titulo.Location = new Point(70, 40);
            Titulo.Size = new Size(200, 40);
            Titulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            Titulo.ForeColor = Color.White;
            Titulo.BackColor = Color.FromArgb(25, 25, 25);

            // metodo pra formatar os botoes
            ConfigurarBotao(btobj01, "Dragon Ball Super", 110);
            ConfigurarBotao(btobj02, "Sword Art Online", 180);
            ConfigurarBotao(btobj03, "Sōsō no Frieren", 250);
            ConfigurarBotao(btobj04, "Chainsawman", 320);
            ConfigurarBotao(btobj05, "RE:Zero", 390);
            ConfigurarBotao(btobj06, "Bleach", 460);

            // eventos
            btobj01.Click += DBS;
            btobj02.Click += SAO;
            btobj03.Click += Frieren;
            btobj04.Click += CSM;
            btobj05.Click += REzero ;
            btobj06.Click += Bleach;

            // adicionando elementos no painel
            painel.Controls.Add(Titulo);

            painel.Controls.Add(btobj01);
            painel.Controls.Add(btobj02);
            painel.Controls.Add(btobj03);
            painel.Controls.Add(btobj04);
            painel.Controls.Add(btobj05);
            painel.Controls.Add(btobj06);

            // config da imagem - posição, size, bordas e cores -
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Size = new Size(320, 320);
            img.Location = new Point(340, 90);
            img.BackColor = Color.White;
            img.BorderStyle = BorderStyle.FixedSingle;

            // label
            txtNome.Location = new Point(720, 80);
            txtNome.Size = new Size(400, 40);
            txtNome.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            txtNome.ForeColor = Color.Black;

            txtEditora.Location = new Point(720, 130);
            txtEditora.Size = new Size(300, 30);
            txtEditora.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            txtEditora.ForeColor = Color.DimGray;

            txtLançamento.Location = new Point(720, 170);
            txtLançamento.Size = new Size(320, 60);
            txtLançamento.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtLançamento.ForeColor = Color.DimGray;

            // descrição
            txtDesc.Location = new Point(720, 230);
            txtDesc.Size = new Size(300, 180);
            txtDesc.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            txtDesc.ForeColor = Color.Black;
            txtDesc.BackColor = Color.White;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.AddRange(new Control[]
            {
                painel,
                img,
                txtLançamento,
                txtEditora,
                txtNome,
                txtDesc
            });

        }

        private void ConfigurarBotao(Button bt, string texto, int y)
        {
            bt.Text = texto;

            bt.Location = new Point(40, y);

            bt.Size = new Size(190, 45);

            bt.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            bt.BackColor = Color.FromArgb(35, 35, 35);

            bt.ForeColor = Color.White;

            bt.FlatStyle = FlatStyle.Flat;

            bt.FlatAppearance.BorderSize = 2;

            bt.FlatAppearance.BorderColor = Color.White;

            bt.Cursor = Cursors.Hand;
        }

        private void MostrarMangas(Mangas p)
        {
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

            txtNome.Text = p.Nome;

            txtEditora.Text = "Editora: " + p.Editora;

            txtLançamento.Text = "Lançamento: " + p.Lançamento;

            txtDesc.Text = p.Desc;
        }

        private void DBS(object sender, EventArgs e)
        {
            MostrarMangas(new DBS());
        }

        private void SAO(object sender, EventArgs e)
        {
            MostrarMangas(new SAO());
        }

        private void Frieren(object sender, EventArgs e)
        {
            MostrarMangas(new Frieren());
        }

        private void CSM(object sender, EventArgs e)
        {
            MostrarMangas(new CSM());
        }

        private void REzero(object sender, EventArgs e)
        {
            MostrarMangas(new REzero());
        }

        private void Bleach(object sender, EventArgs e)
        {
            MostrarMangas(new Bleach());
        }

    }
}