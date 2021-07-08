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
    public partial class AlterarVaga : Form
    {

        String cargoSql;
        String escolaridade_minima;
        String caminhoBanco = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Development_Softwares\Microsoft Visual Studio 2017 projects\SistemaVagas\SistemaVagas\DBsistema_de_vagas.mdf;Integrated Security=True";
        //recebendo cargo específico
        public AlterarVaga(String cargoSql)
        {
            //atribuindo cargo específico ao atributo global cargoSql, como fator condicional para consulta da vaga
            this.cargoSql = cargoSql;
            InitializeComponent();
        }

        public void alterarVaga()
        {
            try
            {
                // recuperando dados informados e armazenando em variáveis
                String cargo = tbVaga.Text;
                String faixa_salarial = tbFaixaSalarial.Text;
                String email_empresa = tbEmailContato.Text;
                String requisitos = tbRequisitos.Text;

                //verificando se alguma caixa de texto esta vazia
                if (cargo == "" || faixa_salarial == "" || email_empresa == "" || requisitos == "" || escolaridade_minima == null)
                {
                    MessageBox.Show("Favor preencher os campos da vaga");
                }
                else
                {
                    //abrindo conexão com banco de dados
                    SQLServerOperations operation = new SQLServerOperations(caminhoBanco);
                    //enviando dados informados para atualizar vaga específica
                    operation.alterarVaga(cargoSql.Trim(), cargo.Trim(), faixa_salarial.Trim(), requisitos.Trim(), escolaridade_minima.Trim(), email_empresa.Trim());

                    //retornando para a consulta de vagas
                    ConsultarVagas consultarVagas = new ConsultarVagas();
                    consultarVagas.Show();
                    this.Hide();
                }
            }
            catch (Exception eAlterando)
            {
                MessageBox.Show(eAlterando.ToString());
            }
        }

        private void bAlterarVaga_Click(object sender, EventArgs e)
        {
            alterarVaga();
        }

        private void btVoltarConsultarVagas_Click(object sender, EventArgs e)
        {
            //voltando para menu de vagas
            ConsultarVagas consultar = new ConsultarVagas();
            consultar.Show();
            this.Hide();
        }

        private void AlterarVaga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBsistema_de_vagasDataSet.vaga' table. You can move, or remove it, as needed.
            this.vagaTableAdapter.Fill(this.dBsistema_de_vagasDataSet.vaga);

            //instanciando banco de dados
            SqlConnection sqlConnection = new SqlConnection(caminhoBanco);
            
            //instrucao = "SELECT cargo, faixa_salarial, requisitos, escolaridade_minima, email_empresa FROM vaga WHERE cargo = '" + cargoSql + "'";
            //String instrucao = "SELECT cargo, faixa_salarial, requisitos, escolaridade_minima, email_empresa FROM vaga WHERE cargo=@cargo";
            //SqlParameter parametroCargo = new SqlParameter("@cargo", SqlDbType.VarChar);
            // parametroCargo.Value = cargoSql;
            try
            {
                //cargoSql = " "+cargoSql+" ";

                //deixando instrução vazia
                String instrucao = string.Empty;
                //consultando dados da vaga específica
                instrucao = "SELECT cargo, faixa_salarial, requisitos, escolaridade_minima, email_empresa FROM vaga WHERE (cargo=@cargo)";
                //abrindo conexão com banco
                sqlConnection.Open();             
                
                //executando instrução
                SqlCommand executarDeclaracaoSql = new SqlCommand(instrucao, sqlConnection);
                //executarDeclaracaoSql.Parameters.Add(parametroCargo);
                
                // adicionando o parâmetro cargo a declaração sql e atribuindo seu valor
               executarDeclaracaoSql.Parameters.Add("@cargo", SqlDbType.VarChar).Value =  cargoSql;                

                //resgatando dados de consulta e armazenando em um objeto leitor de dados
                SqlDataReader dadosSql =  executarDeclaracaoSql.ExecuteReader();

                //enquanto houver registros, execute o bloco de código abaixo
              while (dadosSql.Read())
                    {
                        //String dadoTeste = Convert.ToString(dadosSql[0]);
                        //MessageBox.Show(Convert.ToString(dadosSql["escolaridade_minima"]));

                        // atribuindo dados da vaga específica da tabela as caixas de texto
                        tbVaga.Text = Convert.ToString(dadosSql["cargo"]);
                        cargoSql = Convert.ToString(dadosSql["cargo"]);
                        tbFaixaSalarial.Text = Convert.ToString(dadosSql["faixa_salarial"]);
                        tbRequisitos.Text = Convert.ToString(dadosSql["requisitos"]);
                        escolaridade_minima = Convert.ToString(dadosSql["escolaridade_minima"]);

                        //verificando qual botão de rádio confere com a escolaridade mínima da tabela, em caso verdadeiro              
                        if (escolaridade_minima.Equals("Ensino Fundamental"))
                        {
                            // deixar botão de rádio marcado
                            rbFundamental.Checked = true;
                        }
                        if (escolaridade_minima.Equals("Ensino Médio"))
                        {
                            rbMedio.Checked = true;
                        }
                        if (escolaridade_minima.Equals("Ensino Técnico"))
                        {
                            rbTecnico.Checked = true;
                        }
                        if (escolaridade_minima.Equals( "Ensino Superior"))
                        {
                            rbSuperior.Checked = true;
                        }
                        tbEmailContato.Text = Convert.ToString(dadosSql["email_empresa"]);

                    }
              //encerrando varredura de registros
                dadosSql.Close();
              // encerrando conexão com banco de dados
                sqlConnection.Close();
            }          
                
        
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle+" falha no banco de dados");
            }

            finally
            {
                sqlConnection.Close();
            }
            
        }

        private void rbFundamental_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
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

        private void vagaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vagaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBsistema_de_vagasDataSet);

        }

    
    }
}
