Console.WriteLine("Digite valor: ");
int valorInformado = Convert.ToInt32(Console.ReadLine());

int numeroAnterior = 0;
int numeroAtual = 1;
int fibonacci = 0;

   
while (fibonacci < valorInformado)
{
    fibonacci = numeroAnterior + numeroAtual; 
    numeroAnterior = numeroAtual; 
    numeroAtual = fibonacci;
}  
       

if (valorInformado == fibonacci)
{
    Console.WriteLine("Pertece a sequência!");
}else
{
    Console.WriteLine("Não Pertece a sequência!");
}