using System;

class Program
{
    //Questão 4 - Faturamento mensal
    static void Main()
    {
        double SP = 67.83643f;
        double RJ = 36.67866f;
        double MG = 29.22988;
        double ES = 27.16548;
        double Outros = 19.84953;
        double SomaTotal = 0;
        double PercentualSP = 0;
        double PercentualRJ = 0;
        double PercentualMG = 0;
        double PercentualES = 0;
        double PercentualOutros = 0;

        int Contagem = 0;

      

        SomaTotal = (SP + RJ + MG + ES + Outros);

        PercentualSP = Math.Round(((SP * 100) / SomaTotal), 2);
        PercentualRJ = Math.Round(((RJ * 100) / SomaTotal), 2);
        PercentualMG = Math.Round(((MG * 100) / SomaTotal), 2);
        PercentualES = Math.Round(((ES * 100) / SomaTotal), 2);
        PercentualOutros = Math.Round(((Outros * 100) / SomaTotal),2);

        Console.WriteLine("Percentuais:\n" +
            "SP: {0}%\n" +
            "RJ: {1}%\n" +
            "MG: {2}%\n" +
            "ES: {3}%\n" +
            "Outros: {4}%\n", PercentualSP, PercentualRJ,PercentualMG, PercentualES, PercentualOutros );



        Console.Read();
    }
}