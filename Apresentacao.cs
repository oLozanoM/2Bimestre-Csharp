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

        // Objeto
        PictureBox img = new PictureBox();

        Label txtDesc = new Label();
        Label txtCor = new Label();
        Label txtMarca = new Label();
        Label txtModelo = new Label();
        Label Titulo = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btobj04 = new Button();
        Button btobj05 = new Button();
        Button btobj06 = new Button();

        //Painel
        Panel painel = new Panel();

        public Apresentacao()
        {
            this.Icon = new Icon(@"../../IMG/adidas.ico");
            this.Text = "Tênis da Adidas";
            this.Size = new Size(1100, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Painel lateral
            painel.BackColor = Color.FromArgb(25, 25, 25);
            painel.Dock = DockStyle.Left;
            painel.Width = 280;

            // Título
            Titulo.Text = "ADIDAS";
            Titulo.Location = new Point(70, 40);
            Titulo.Size = new Size(200, 40);
            Titulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            Titulo.ForeColor = Color.White;
            Titulo.BackColor = Color.FromArgb(25, 25, 25);

            // Configuração dos botões
            ConfigurarBotao(btobj01, "SuperStar", 110);
            ConfigurarBotao(btobj02, "Campus", 180);
            ConfigurarBotao(btobj03, "Samba", 250);
            ConfigurarBotao(btobj04, "Forum", 320);
            ConfigurarBotao(btobj05, "Forum 2000", 390);
            ConfigurarBotao(btobj06, "Adi2000", 460);

            // Eventos
            btobj01.Click += SuperStar;
            btobj02.Click += Campus;
            btobj03.Click += Samba;
            btobj04.Click += Forum;
            btobj05.Click += Forum2000;
            btobj06.Click += Adi2000;

            // Adicionando no painel
            painel.Controls.Add(Titulo);

            painel.Controls.Add(btobj01);
            painel.Controls.Add(btobj02);
            painel.Controls.Add(btobj03);
            painel.Controls.Add(btobj04);
            painel.Controls.Add(btobj05);
            painel.Controls.Add(btobj06);

            // Configuração da imagem
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Size = new Size(320, 320);
            img.Location = new Point(340, 90); // imagem agora na esquerda
            img.BackColor = Color.White;
            img.BorderStyle = BorderStyle.FixedSingle;

            // Labels principais
            txtModelo.Location = new Point(720, 80);
            txtModelo.Size = new Size(400, 40);
            txtModelo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            txtModelo.ForeColor = Color.Black;

            txtMarca.Location = new Point(720, 130);
            txtMarca.Size = new Size(300, 30);
            txtMarca.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            txtMarca.ForeColor = Color.DimGray;

            txtCor.Location = new Point(720, 170);
            txtCor.Size = new Size(320, 60);
            txtCor.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtCor.ForeColor = Color.DimGray;

            // Descrição
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
                txtCor,
                txtMarca,
                txtModelo,
                txtDesc
            });

        }

        // Método para estilizar botão
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

        private void MostrarTenis(Tenis p)
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

            txtModelo.Text = p.Nome;

            txtMarca.Text = "Marca: " + p.Marca;

            txtCor.Text = "Cor: " + p.Cor;

            txtDesc.Text = p.Desc;
        }

        private void SuperStar(object sender, EventArgs e)
        {
            MostrarTenis(new Star());
        }

        private void Campus(object sender, EventArgs e)
        {
            MostrarTenis(new Campus());
        }

        private void Samba(object sender, EventArgs e)
        {
            MostrarTenis(new Samba());
        }

        private void Forum(object sender, EventArgs e)
        {
            MostrarTenis(new Forum());
        }

        private void Forum2000(object sender, EventArgs e)
        {
            MostrarTenis(new Forum2000());
        }

        private void Adi2000(object sender, EventArgs e)
        {
            MostrarTenis(new Adi2000());
        }

    }
}