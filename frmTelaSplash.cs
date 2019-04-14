using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultOperacoes
{
    public partial class frmTelaSplash : Form
    {
        public frmTelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pbCarrega.Value<=40)
            {
                pbCarrega.Value = pbCarrega.Value + 4;
                lblMensagem.Text = "Iniciando sistema..." + pbCarrega.Value + "%";
            }
            else
                if(pbCarrega.Value<=60)
            {
                pbCarrega.Value = pbCarrega.Value+ 4;
                lblMensagem.Text = "Processando..." + pbCarrega.Value + "%";
            }
            else
                if(pbCarrega.Value<90)
            {
                pbCarrega.Value = pbCarrega.Value + 4;
                lblMensagem.Text = "Aguarde..." + pbCarrega.Value + "%";
            }
            if(pbCarrega.Value>90)
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmTelaPrincipal principal = new frmTelaPrincipal();
                principal.ShowDialog();
            }
        }
    }
}
