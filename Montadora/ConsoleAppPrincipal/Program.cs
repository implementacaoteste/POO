using Models;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, "Carro de passeio", "Firestone", false, 150);
            
            pneu1.Girar(5);

            pneu1.Exibir();
        }
    }
}