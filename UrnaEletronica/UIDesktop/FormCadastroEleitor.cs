using BLL;
using Models;

namespace UIDesktop
{
    public partial class FormCadastroEleitor : Form
    {
        public FormCadastroEleitor()
        {
            InitializeComponent();
        }

        private void FormCadastroEleitor_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Inserir((Eleitor)bindingSource1.Current);

        }
    }
}