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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar todos os dados inseridos?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {


                //Apaga todos os valores
                txtPrimeiroNumero.Clear();
                txtSegundoNumero.Clear();
                txtTotal.Clear();
                txtDiferenca.Clear();
                txtProduto.Clear();
                txtQuociente.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realemente fechar o programa?","Fechar programa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txtPrimeiroNumero.Text == "" || txtSegundoNumero.Text == "")
            {
                MessageBox.Show("Verifique os dados, tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
            else
            {
                try
                {
                    //declarando as variáveis
                    double primeiroValor, segundoValor, total, diferenca, produto, quociente;
                    primeiroValor = double.Parse(txtPrimeiroNumero.Text);
                    segundoValor = double.Parse(txtSegundoNumero.Text);


                    //PROCESSAMENTO DE DADOS

                    //Processa a adição
                    total = primeiroValor + segundoValor;

                    //Processa a diferença
                    diferenca = primeiroValor - segundoValor;

                    //Processa o produto
                    produto = primeiroValor * segundoValor;

                    //Processa o quociente           
                    primeiroValor = double.Parse(txtPrimeiroNumero.Text);
                    segundoValor = double.Parse(txtSegundoNumero.Text);

                    quociente = primeiroValor / segundoValor;

                    if (primeiroValor != 0 && segundoValor == 0)
                    {
                        MessageBox.Show("Impossível dividir por zero, tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                
                    }                    

                    //RESULTADO DO PROCESSAMENTO

                    //Mostra o total
                    txtTotal.Text = total.ToString();

                    //Mostra a diferença
                    txtDiferenca.Text = diferenca.ToString();

                    //Mostra o produto
                    txtProduto.Text = produto.ToString();

                    //Mostra o quociente
                    txtQuociente.Text = quociente.ToString();

                }
                catch(FormatException)
                {
                    
                    MessageBox.Show("Ocorre algo errado, verifique os dados inseridos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Clear();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtSegundoNumero.Clear();
        }
    }
}
