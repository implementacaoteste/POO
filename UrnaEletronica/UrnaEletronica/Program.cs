using BLL;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Eleitor eleitor = new Eleitor("9999", "SP", 3);
            EleitorBLL eleitorBLL = new EleitorBLL();
            eleitorBLL.Excluir(eleitor);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}