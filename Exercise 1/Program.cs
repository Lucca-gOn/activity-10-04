//1. RECEBER NOTA ENTRE 0 e 10;
//2. MSG CASO O VALOR SEJA INVALIDO E CONTINUE PEDINDO ATE O VALOR SER VÁLIDO;

Console.WriteLine($"Informe a nota do aluno de 0 a 10: ");
int notaAluno = int.Parse(Console.ReadLine());

while (notaAluno < 0 || notaAluno > 10)
{
    Console.WriteLine($"Por gentileza digite um valor válido, tente novamente!");
    notaAluno = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Nota recebida com sucesso!");

