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
    public partial class ConsultarVagas : Form
    {
        String caminhoBanco = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Development_Softwares\Microsoft Visual Studio 2017 projects\SistemaVagas\SistemaVagas\DBsistema_de_vagas.mdf;Integrated Security=True";
        public ConsultarVagas()
        {
            InitializeComponent();
        }

        public void atualizarDataGrid()
        {
            //instanciando conexão com banco
            SqlConnection sqlConnection = new SqlConnection(caminhoBanco);
            //abrindo conexão com banco
            sqlConnection.Open();

            ///instrução de consulta
            String instrucao = "SELECT cargo, faixa_salarial, requisitos, escolaridade_minima, email_empresa FROM vaga";

            //executando consulta pelo adaptador de dados
            SqlDataAdapter adaptadorDadosSql = new SqlDataAdapter(instrucao,sqlConnection);

            //criando conjunto de dados vazio
            DataSet conjuntoDados = new DataSet();

            //preenchendo conjunto com os registros da tabela vaga
            adaptadorDadosSql.Fill(conjuntoDados, "vaga");

           //atribuindo dados recuperando a fonte de dados da grade          
            vagaDataGridView.DataSource = conjuntoDados;
            vagaDataGridView.DataMember = "vaga";

            //encerrando conexão com banco
            sqlConnection.Close();
           
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btConsultarVaga_Click(object sender, EventArgs e)
        {
            //capturando cargo informado
            String cargo = tbCargo.Text;
            SqlConnection sqlConnection = new SqlConnection(caminhoBanco);
            sqlConnection.Open();

            ///instrução de consulta por vaga específica
            String instrucao = "SELECT cargo, faixa_salarial, requisitos, escolaridade_minima, email_empresa FROM vaga WHERE cargo = '" + cargo.Trim() + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(instrucao,sqlConnection);

            DataSet vagaEspecifica = new DataSet();

            sqlDataAdapter.Fill(vagaEspecifica, "vaga");

            vagaDataGridView.DataSource = vagaEspecifica;
            vagaDataGridView.DataMember = "vaga";

            sqlConnection.Close();

        }

        private void btAlterarVaga_Click(object sender, EventArgs e)
        {
            //capturando cargo informado
            String cargo = tbCargo.Text;
            //abrindo formulário de alteração da vaga específica
            AlterarVaga alterar =  new AlterarVaga(cargo);
            alterar.Show();
            this.Hide();                       
        }

        //carregando dados da tabela do banco e atualizando a grade de dados
        private void ConsultarVagas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBsistema_de_vagasDataSet.vaga' table. You can move, or remove it, as needed.
            this.vagaTableAdapter.Fill(this.dBsistema_de_vagasDataSet.vaga);
            atualizarDataGrid();

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            //retornando ao menu principal
            MenuVagas menu = new MenuVagas();
            menu.Show();
            this.Hide();
        }

        private void vagaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vagaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBsistema_de_vagasDataSet);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vagaTableAdapter.FillBy(this.dBsistema_de_vagasDataSet.vaga);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void vagaDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            this.vagaTableAdapter.Fill(this.dBsistema_de_vagasDataSet.vaga);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

    }
}
