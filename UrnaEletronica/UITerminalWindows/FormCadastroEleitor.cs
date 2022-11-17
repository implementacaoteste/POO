using BLL;
using Models;

namespace UITerminalWindows
{
    public partial class FormCadastroEleitor : Form
    {
        public FormCadastroEleitor()
        {
            InitializeComponent();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bindingSourceEleitor.EndEdit();
            EleitorBLL eleitorBLL = new EleitorBLL();
            
            eleitorBLL.Inserir((Eleitor)bindingSourceEleitor.Current);

            MessageBox.Show("Eleitor salvo com sucesso!");
            Close();
        }
        private void FormCadastroEleitor_Load(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();
            bindingSourceEleitor.DataSource = eleitor;
            bindingSourceEleitor.AddNew();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}