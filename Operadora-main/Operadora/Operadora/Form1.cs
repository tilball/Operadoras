using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadora
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            //Muda a cor do fundo
            BackColor = Color.DarkViolet;
            //Escreva o nome vivo
            txt_OperadoraSelecionada.Text = Rad_Vivo.Text;
            //Muda a Logo que aparece
            pic_Logo.Image = Properties.Resources._20191105041658_1144x450;
            //Ativar
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;

            //Valores e validade das Recargas
            btn_RS1.Text = "12 reais";
            lbl_Validade1.Text = "30 dias";

            btn_RS2.Text = "15 reais";
            lbl_Validade2.Text = "30 dias";

            btn_RS3.Text = "20 reais";
            lbl_Validade3.Text = "30 dias";

            btn_RS4.Text = "30 reais";
            lbl_Validade4.Text = "30 dias";

            btn_RS5.Text = "35 reais";
            lbl_Validade5.Text = "90 dias";

            btn_RS6.Text = "40 reais";
            lbl_Validade6.Text = "90 dias";

            btn_RS7.Text = "100 reais";
            lbl_Validade7.Text = "180 dias";

            btn_RS8.Text = "200 reais";
            lbl_Validade8.Text = "365 dias";
        }

        private void pcb_image_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Oi_CheckedChanged(object sender, EventArgs e)
        {
            //Muda a cor do fundo
            BackColor = Color.DarkOrange;
            //Escreva o nome vivo
            txt_OperadoraSelecionada.Text = Rad_Oi.Text;
            //Muda a Logo que aparece
            pic_Logo.Image = Properties.Resources._7874b0243663287a3c56bca05a1d395d;
            //Ativar as propiedades
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;

            //Valores e validade das Recargas
            btn_RS1.Text = "10 reais";
            lbl_Validade1.Text = "30 dias";

            btn_RS2.Text = "15 reais";
            lbl_Validade2.Text = "30 dias";

            btn_RS3.Text = "20 reais";
            lbl_Validade3.Text = "45 dias";

            btn_RS4.Text = "25 reais";
            lbl_Validade4.Text = "45 dias";

            btn_RS5.Text = "30 reais";
            lbl_Validade5.Text = "90 dias";

            btn_RS6.Text = "35 reais";
            lbl_Validade6.Text = "90 dias";

            btn_RS7.Text = "40 reais";
            lbl_Validade7.Text = "90 dias";

            btn_RS8.Text = "50 reais";
            lbl_Validade8.Text = "90 dias";
        }

        private void btn_Claro_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Red;
            //Escreva o nome vivo
            txt_OperadoraSelecionada.Text = Rad_Claro.Text;
            //Muda a Logo que aparece
            pic_Logo.Image = Properties.Resources.claro;
            //Ativar as propiedades
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;

            //Valores e validade das Recargas
            btn_RS1.Text = "12 reais";
            lbl_Validade1.Text = "30 dias";

            btn_RS2.Text = "15 reais";
            lbl_Validade2.Text = "30 dias";

            btn_RS3.Text = "20 reais";
            lbl_Validade3.Text = "60 dias";

            btn_RS4.Text = "25 reais";
            lbl_Validade4.Text = "60 dias";

            btn_RS5.Text = "30 reais";
            lbl_Validade5.Text = "90 dias";

            btn_RS6.Text = "35 reais";
            lbl_Validade6.Text = "90 dias";

            btn_RS7.Text = "50 reais";
            lbl_Validade7.Text = "120 dias";

            btn_RS8.Text = "100 reais";
            lbl_Validade8.Text = "180 dias";
        }

        private void btn_Tim_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Blue;
            //Escreva o nome vivo
            txt_OperadoraSelecionada.Text = Rad_Tim.Text;
            //Muda a Logo que aparece
            pic_Logo.Image = Properties.Resources.TIM_Symbole;
            //Ativar as propiedades
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;

            //Valores e validade das Recargas
            btn_RS1.Text = "10 reais";
            lbl_Validade1.Text = "30 dias";

            btn_RS2.Text = "15 reais";
            lbl_Validade2.Text = "30 dias";

            btn_RS3.Text = "20 reais";
            lbl_Validade3.Text = "30 dias";

            btn_RS4.Text = "30 reais";
            lbl_Validade4.Text = "90 dias";

            btn_RS5.Text = "40 reais";
            lbl_Validade5.Text = "90 dias";

            btn_RS6.Text = "50 reais";
            lbl_Validade6.Text = "180 dias";

            btn_RS7.Text = "60 reais";
            lbl_Validade7.Text = "180 dias";

            btn_RS8.Text = "100 reais";
            lbl_Validade8.Text = "180 dias";
        }

        private void pic_Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
