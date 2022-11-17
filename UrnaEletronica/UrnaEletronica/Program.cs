using BLL;
using Models;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Eleitor eleitor = new Eleitor("9999", "Teste 2", 3);
            EleitorBLL eleitorBLL = new EleitorBLL();
            
            DataTable dataTable = eleitorBLL.BuscarPorTitulo("555555");

            eleitorBLL.Inserir(eleitor);
            eleitor.Nome = "Mazarope";
            eleitor.Titulo = "00000000";
            eleitor.Votou = true;
            eleitor.Id = 10;
            eleitorBLL.Alterar(eleitor);
            eleitorBLL.Excluir(eleitor);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}