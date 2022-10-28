using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pneu pneuMichelan = new Pneu(16, "Michelan");

        Carro corcel = new Carro("Chevrolet", "2");
        corcel.LigarDesligar();
        //corcel.Acelerar(31);
        corcel.Abastecer(50);
        //corcel.Frear(30);

        for (int i = 0; i < 20; i++)
        {
            corcel.Acelerar(15);
            corcel.Frear(14);
        }

        corcel.PneuTrazeiroEsquerdo = pneuMichelan;
        corcel.LigarDesligar();

        corcel.LigarDesligar();
        for (int i = 0; i < 20; i++)
        {
            corcel.Acelerar(15);
            corcel.Frear(14);
        }
        corcel.Exibir();
    }
}