using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaVagas
{
    public partial class CadastrarVagas : Form
    {
        String escolaridade_minima;
        public CadastrarVagas()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void cadastrar_vaga()
        {
            try
            {
                
                //recuperando valores informados nas caixas de texto
                String cargo = tbVaga.Text;
                String faixa_salarial = tbFaixaSalarial.Text;              
                String requisitos = tbRequisitos.Text;
                String email_empresa = tbEmailContato.Text;

                //verificando se algum campo está vazio
                if(cargo == "" ||  faixa_salarial =="" || requisitos=="" || email_empresa=="" || escolaridade_minima =="")
                {
                    //disparando caixa de dialogo
                    MessageBox.Show("Favor preencher os campos da vaga");
                }
                else
                {
                    String caminhoBanco = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Development_Softwares\Microsoft Visual Studio 2017 projects\SistemaVagas\SistemaVagas\DBsistema_de_vagas.mdf;Integrated Security=True";

                    //instanciando banco de dados do caminho acima
                    SQLServerOperations operation = new SQLServerOperations(caminhoBanco);
                    //enviando dados sem espaçamento para inserção na tabela
                    operation.inserirVaga(cargo.Trim(), faixa_salarial.Trim(), requisitos.Trim(), escolaridade_minima.Trim(), email_empresa.Trim());

                    //label8.Text = cargo + " " + faixa_salarial + " " + requisitos + " " + email_empresa + " " + escolaridade_minima;

                    //limpando texto das caixas de texto
                    tbVaga.Text = "";
                    tbFaixaSalarial.Text = "";
                    tbRequisitos.Text = "";
                    tbEmailContato.Text = "";

                    ///retornando para o menu principal
                    MenuVagas vagas = new MenuVagas();
                    vagas.Show();
                    this.Hide();
                }
               
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2627)
                {
                    MessageBox.Show("Esta Vaga já foi cadastrada anteriormente, favor preencher com outro cargo");
                }
                else if (sqle.Number == 2601 )
                {
                    MessageBox.Show("Esta Vaga já foi cadastrada anteriormente, favor preencher com outro cargo");
                }
               
            }
          
        }

        //disparando evento de clique
        private void bInserirVaga_Click(object sender, EventArgs e)
        {
            //chamando o método cadastrar vaga
            cadastrar_vaga();
        }

        //verificando se o botão de rádio foi marcado
        private void rbFundamental_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            //se sim
            if (radio.Checked)
            {
                //variável recebe o texto do botão de rádio
                escolaridade_minima = radio.Text;
            }
        }

        private void rbTecnico_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                escolaridade_minima = radio.Text;
            }

        }

        private void rbMedio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                escolaridade_minima = radio.Text;
            }
        }

        private void rbSuperior_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                escolaridade_minima = radio.Text;
            }
        }

        private void tbFaixaSalarial_TextChanged(object sender, EventArgs e)
        {

        }

        //enter+leave == efeito de hint/placeholder

        private void tbFaixaSalarial_Enter(object sender, EventArgs e)
        {
            if (tbFaixaSalarial.Text == "Ex: até 1.200, maior que 3000")
            {
                tbFaixaSalarial.Text = "";

                tbFaixaSalarial.ForeColor = Color.Black;
            }
        }

        private void tbFaixaSalarial_Leave(object sender, EventArgs e)
        {
            if (tbFaixaSalarial.Text == "")
            {
                tbFaixaSalarial.Text = "Ex: até 1.200, maior que 3000";

                tbFaixaSalarial.ForeColor = Color.Silver;
            }
        }

        

    }
}
