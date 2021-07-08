using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVagas
{
    public partial class MenuVagas : Form
    {
        public MenuVagas()
        {
            InitializeComponent();
        }

        //disparando evento de clique do botão
        private void btCadastrarVaga_Click(object sender, EventArgs e)
        {
            //abrindo formulário para cadastrar vaga
            CadastrarVagas formCadastrar = new CadastrarVagas();
            formCadastrar.Show();
            this.Hide();            
        }

        //disparando evento de clique do botão
        private void btConsultarVagas_Click(object sender, EventArgs e)
        {
            //abrindo formulário para consultar vagas
            ConsultarVagas formConsultarVagas = new ConsultarVagas();
            formConsultarVagas.Show();
            this.Hide();
        }

        private void MenuVagas_Load(object sender, EventArgs e)
        {

        }

        //disparando evento de clique do botão e encerrando aplicação em definitivo
        private void btEncerrarAp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
