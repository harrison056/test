
double SP =  67836.43;
double RJ = 36678.66;
double MG = 29229.88;
double ES = 27165.48;
double outro = 19849.53;

double soma = SP + RJ + MG + ES + outro;
Console.WriteLine("Valor Total: " +soma);

double perSP = (SP * 100) / soma;
double perRJ = (RJ * 100) / soma;
double perMG = (MG * 100) / soma;
double perES = (ES * 100) / soma;
double perOutro = (outro * 100) / soma;


Console.WriteLine("SP: "+ SP + " - " + perSP.ToString("N2") + "%");
Console.WriteLine("RJ: "+ RJ + " - " + perRJ.ToString("N2") + "%");
Console.WriteLine("MG: "+ MG + " - " + perMG.ToString("N2") + "%");
Console.WriteLine("ES: "+ ES + " - " + perES.ToString("N2") + "%");
Console.WriteLine("Outros: "+ outro + " - " + perOutro.ToString("N2") + "%");