using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Dictionary<string, Heroi> herois = new Dictionary<string, Heroi>();

        public Form1()
        {
            InitializeComponent();
        }

        void CamposObrigatorios()
        { 
            if (tbNomeR.Text == "")
            {
                labelCampoObrigatorio2.Visible = true;
            }
            if (nudPoder.Value == 0)
            {
                labelCampoObrigatorio3.Visible = true;
            }
            if (nudAltura.Value == 0)
            {
                labelCampoObrigatorio4.Visible = true;
            }
            if (nudIdade.Value == 0)
            {
                labelCampoObrigatorio5.Visible = true;
            }
            if (nudPeso.Value == 0)
            {
                labelCampoObrigatorio6.Visible = true;
            }
        }

        void LimparEdicao()
        {
            tbNomeHeroiE.Clear();

            nudPOE.Value = 0;
            nudAE.Value = 0;
            nudIDE.Value = 0;
            nudPEE.Value = 0;

            nudFE.Value = 0;
            nudITE.Value = 0;
            nudLE.Value = 0;
            nudME.Value = 0;
            nudSE.Value = 0;
            nudVE.Value = 0;
        }

        void EditarCampos()
        {
            herois[tbPesquisarNomeR.Text].SetNomeH = tbNomeHeroiE.Text;

            herois[tbPesquisarNomeR.Text].SetPoder = (int)nudPOE.Value;
            herois[tbPesquisarNomeR.Text].SetAltura = (double)nudAE.Value;
            herois[tbPesquisarNomeR.Text].SetIdade = (int)nudIDE.Value;
            herois[tbPesquisarNomeR.Text].SetPeso = (int)nudPEE.Value;

            herois[tbPesquisarNomeR.Text].SetForca = (int)nudFE.Value;
            herois[tbPesquisarNomeR.Text].SetInteligencia = (int)nudITE.Value;
            herois[tbPesquisarNomeR.Text].SetLuta = (int)nudLE.Value;
            herois[tbPesquisarNomeR.Text].SetMagia = (int)nudME.Value;
            herois[tbPesquisarNomeR.Text].SetSocial = (int)nudSE.Value;
            herois[tbPesquisarNomeR.Text].SetVelocidade = (int)nudVE.Value;

            MessageBox.Show(tbPesquisarNomeR.Text + " editado com sucesso");
        }

        void LimparCampos()
        {
            tbNomeR.Clear();
            tbNomeH.Clear();

            nudPoder.Value = 0;
            nudAltura.Value = 0;
            nudIdade.Value = 0;
            nudPeso.Value = 0;

            nudF.Value = 0;
            nudI.Value = 0;
            nudL.Value = 0;
            nudM.Value = 0;
            nudS.Value = 0;
            nudV.Value = 0;

        }

        void LimparObrigatorios()
        {
            labelCampoObrigatorio2.Visible = false;
            labelCampoObrigatorio3.Visible = false;
            labelCampoObrigatorio4.Visible = false;
            labelCampoObrigatorio5.Visible = false;
            labelCampoObrigatorio6.Visible = false;
        }

        void CompletarDados(Heroi editando)
        {
            tbNomeHeroiE.Text = editando.GetNomeH;
            nudPOE.Value = editando.GetPoder;
            nudAE.Value = (decimal)editando.GetAltura;
            nudIDE.Value = editando.GetIdade;
            nudPEE.Value = editando.GetPeso;
            nudFE.Value = editando.GetForca;
            nudITE.Value = editando.GetInteligencia;
            nudLE.Value = editando.GetLuta;
            nudME.Value = editando.GetMagia;
            nudSE.Value = editando.GetSocial;
            nudVE.Value = editando.GetVelocidade;
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparObrigatorios();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            CamposObrigatorios();

            if (labelCampoObrigatorio2.Visible == false && labelCampoObrigatorio3.Visible == false
               && labelCampoObrigatorio4.Visible == false && labelCampoObrigatorio5.Visible == false
               && labelCampoObrigatorio6.Visible == false)
            {
                Heroi heroi = new Heroi((int)nudIdade.Value, (int)nudPeso.Value, (int)nudPoder.Value,
                                      (double)nudAltura.Value, tbNomeH.Text, tbNomeR.Text, (int)nudF.Value,
                                      (int)nudI.Value, (int)nudL.Value, (int)nudM.Value, (int)nudS.Value,
                                      (int)nudV.Value);

                herois.Add(tbNomeR.Text, heroi);

                MessageBox.Show(tbNomeR.Text + " registrado com sucesso");
                
                LimparCampos();
            }
        }

        private void tbNomeR_TextChanged(object sender, EventArgs e)
        {
            labelCampoObrigatorio2.Visible = false;
        }

        private void nudPoder_ValueChanged(object sender, EventArgs e)
        {
            labelCampoObrigatorio3.Visible = false;
        }

        private void nudAltura_ValueChanged(object sender, EventArgs e)
        {
            labelCampoObrigatorio4.Visible = false;
        }

        private void nudIdade_ValueChanged(object sender, EventArgs e)
        {
            labelCampoObrigatorio5.Visible = false;
        }

        private void nudPeso_ValueChanged(object sender, EventArgs e)
        {
            labelCampoObrigatorio6.Visible = false;
        }
        
        private void bPesquisar_Click(object sender, EventArgs e)
        {
            if (herois.ContainsKey(tbPesquisarNomeR.Text))
            {
                CompletarDados(herois[tbPesquisarNomeR.Text]);
            }
            else
            {
                LimparEdicao();
                labelSemHeroi.Visible = true;
            }
        }
        private void tbPesquisarNomeR_TextChanged(object sender, EventArgs e)
        {
            labelSemHeroi.Visible = false;
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            EditarCampos();
        }

        private void bLimparE_Click(object sender, EventArgs e)
        {
            LimparEdicao();
        }

        private void bApagar_Click(object sender, EventArgs e)
        {
            string aviso = "Tem certeza que deseja apagar?";
            string titulo = "Confirmação";
            var result = MessageBox.Show(aviso, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                herois.Remove(tbPesquisarNomeR.Text);
                MessageBox.Show(tbPesquisarNomeR.Text + " apagado com sucesso");
            }
        }
    }

    class Heroi
    {
        int idade;
        int peso;
        int poder;
        double altura;
        string nomeH;
        string nomeR;

        int forca;
        int inteligencia;
        int luta;
        int magia;
        int social;
        int velocidade;

        public Heroi(int idade, int peso, int poder, double altura, string nomeH, string nomeR, 
        int forca, int inteligencia, int luta, int magia, int social, int velocidade)
        {
            this.idade = idade;
            this.peso = peso;
            this.poder = poder;
            this.altura = altura;
            this.nomeH = nomeH;
            this.nomeR = nomeR;

            this.forca = forca;
            this.inteligencia = inteligencia;
            this.luta = luta;
            this.magia = magia;
            this.social = social;
            this.velocidade = velocidade;
        }

        public string GetNomeH
        {
            get
            {
                return nomeH;
            }
        }

        public int GetPoder
        {
            get
            {
                return poder;
            }
        }

        public double GetAltura
        {
            get
            {
                return altura;
            }
        }

        public int GetIdade
        {
            get
            {
                return idade;
            }
        }

        public int GetPeso
        {
            get
            {
                return peso;
            }
        }

        public int GetForca
        {
            get
            {
                return forca;
            }
        }

        public int GetInteligencia
        {
            get
            {
                return inteligencia;
            }
        }

        public int GetLuta
        {
            get
            {
                return luta;
            }
        }

        public int GetMagia
        {
            get
            {
                return magia;
            }
        }

        public int GetSocial
        {
            get
            {
                return social;
            }
        }

        public int GetVelocidade
        {
            get
            {
                return velocidade;
            }
        }

        public string SetNomeH
        {
            set
            {
                nomeH = value;
            }
        }

        public int SetPoder
        {
            set
            {
                poder = value;
            }
        }

        public double SetAltura
        {
            set
            {
                altura = value;
            }
        }

        public int SetIdade
        {
            set
            {
                idade = value;
            }
        }

        public int SetPeso
        {
            set
            {
                peso = value;
            }
        }

        public int SetForca
        {
            set
            {
                forca = value;
            }
        }

        public int SetInteligencia
        {
            set
            {
                inteligencia = value;
            }
        }

        public int SetLuta
        {
            set
            {
                luta = value;
            }
        }

        public int SetMagia
        {
            set
            {
                magia = value;
            }
        }

        public int SetSocial
        {
            set
            {
                social = value;
            }
        }

        public int SetVelocidade
        {
            set
            {
                velocidade = value;
            }
        }

    }
}