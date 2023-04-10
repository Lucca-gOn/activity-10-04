//1. SEXO DO ENTREVISTADO;
//2. SE ELAS GOSTARAM DO PRODUTO;
//3. UTILIZAR SIM OU NÃO;
//4. QUANTOS SIM

int numSim = 0;
int numNao =0;
int numMulheresS =0;
double pctHomensN = 0;
int homensAnalisados = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Entrevistado Nº{i}");
    Console.WriteLine($"Informe o seu sexo: (M) para masculino e (F) para feminino: ");
    char sexo = char.Parse(Console.ReadLine().ToLower());
    Console.WriteLine($"Você gostou do produto: (S) para sim e (N) para não: ");
    char gostouProduto = char.Parse(Console.ReadLine().ToLower());
     
     if (gostouProduto == 's')
     {
        numSim++;
     }
     
     if (gostouProduto == 'n')
     {
        numNao++;
     }
     
     if (sexo == 'f' && gostouProduto == 's')
     {
        numMulheresS++;
     }
    
    pctHomensN = numMulheresS / 10 * 100;
    
    if (sexo == 'm')
    {
        homensAnalisados++;
    }

}
Console.WriteLine($"O número de pessoas que responderam (SIM) é de {numSim} pessoas");
Console.WriteLine($"O número de pessoas que responderam (NÃO) é de {numNao} pessoas");
Console.WriteLine($"O número de mulheres que responderam (SIM) é de {numMulheresS} pessoas");
Console.WriteLine($"A porcentagem de homens que responderam (NÃO) é de {pctHomensN}%");
Console.WriteLine($"Quantidade de homens analisados: {homensAnalisados} ");
