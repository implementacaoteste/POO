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
            Eleitor eleitor = new Eleitor();
            bindingSource1.DataSource = eleitor;
            bindingSource1.AddNew();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Inserir((Eleitor)bindingSource1.Current);
            MessageBox.Show("Eleitor cadastrado com sucesso!");
            Close();
        }
    }
}