using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaDeTreinamento
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonTabCursos_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ativarBotao(Button navButton)
        {
            navButton.BackColor = Color.FromArgb(253, 84, 68);

            var tituloPrincipal = navButton.Text;

            labelTituloPrincipal.Text = tituloPrincipal;
        }

        private void desativaBotao(Panel panelNavigation)
        {
            foreach(Control previousBtn in panelNavigation.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(40, 40, 40);
                }
            }
        }

        private void buttonTabCursos_Click(object sender, EventArgs e)
        {
            desativaBotao(panelNavigation);
            ativarBotao(buttonTabCursos);
        }

        private void buttonTabMeusCursos_Click(object sender, EventArgs e)
        {
            desativaBotao(panelNavigation);
            ativarBotao(buttonTabMeusCursos);
        }

        private void buttonTabPerfil_Click(object sender, EventArgs e)
        {
            desativaBotao(panelNavigation);
            ativarBotao(buttonTabPerfil);
        }

        private void buttonTabConfiguracoes_Click(object sender, EventArgs e)
        {
            desativaBotao(panelNavigation);
            ativarBotao(buttonTabConfiguracoes);
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            desativaBotao(panelNavigation);

            var tituloPrincipal = "Home";

            labelTituloPrincipal.Text = tituloPrincipal;
        }
    }
}
