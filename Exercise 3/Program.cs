//1. RECEBER NÚMERO INTEIRO;
//2. MOSTRAR TABUADA;

Console.WriteLine($"Informe o número inteiro que deseja mostrar a tabuada:");
int numInt = int.Parse(Console.ReadLine());

for (int i = 0; i <=10; i++)
{
    Console.WriteLine($"{numInt} x {i} = {numInt * i}");
    
}
