using System;
using Newtonsoft.Json;

internal class Program
{   
    private static void Main(string[] args)
    {
        string json = @"json/dados.json";
        if(File.Exists(json))
        {
            int menorDia = 0, maiorDia = 0, count = 0;
            double menorValor = 0, maiorValor = 0, media = 0;
            double soma = 0; //Soma da media
            int div = 0;//divisão de media

            var items = JsonConvert.DeserializeObject<List<Dias>>(File.ReadAllText(json));
            
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].valor > maiorValor)
                {
                    maiorValor = items[i].valor;
                    maiorDia = items[i].dia;
                }
                if (items[i].valor <= items[29].valor && items[i].valor != 0)
                {
                    menorValor = items[i].valor;
                    menorDia = items[i].dia;
                }     
                if (items[i].valor != 0)
                {
                    div ++;
                    soma = soma + items[i].valor;
                    media = (soma + items[i].valor) / div;
                }       
            }

            Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês: Dia "+ menorDia +" - R$" + menorValor);
            Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês: Dia "+ maiorDia +" - R$" + maiorValor);
            Console.WriteLine("\nDias acima da média: \n");
            for (int i = 0; i < items.Count; i++)
            {
                if (media < items[i].valor)
                {
                    Console.WriteLine("Dia " + items[i].dia + " - R$ " + items[i].valor);
                    count ++;
                } 
            }
            Console.WriteLine("\nTotal de " + count + " Dias!");
        }
    }

    public class Dias
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
}