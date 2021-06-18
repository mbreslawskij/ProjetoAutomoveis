using System;

namespace ProjClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string motorista = "Airton Sena";

            Customisados golT = new Customisados();
            golT.AnoModelo = 2012;
            golT.Cilindradas = 1000;
            golT.Alteracoes = "Original";

            Esportivos ferrari = new Esportivos();
            ferrari.AnoModelo = 2018;
            ferrari.Cilindradas = 6496;
            ferrari.Cor = "Vermelha";
            ferrari.Alteracoes = "Rodas";

            CLassicos dodge = new CLassicos();
            dodge.AnoModelo = 1978;
            dodge.Cilindradas = 5212;
            dodge.Cor = "Preto";

        }
    }
}
