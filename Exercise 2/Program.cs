//1. RECEBER NOME DE USUARIO;
//2. RECEBER SENHA;
//3. NÃO ACEITAR SENHA IGUAL AO NOME DE USUARIO;
//4. MSG DE ERRO E PEDIR INFORMAÇOES NOVAMENTE;


Console.WriteLine($"Informe o seu nome de usuario: ");
string userName = Console.ReadLine();

Console.WriteLine($"Informe a sua senha: ");
string senha = Console.ReadLine();

while (userName == senha)
{
    Console.WriteLine($"Infome uma senha que (não) seja igual ao nome de usuario. Tente novamente!");
    
    Console.WriteLine($"Digite o seu nome de usuario: ");
    userName = Console.ReadLine();
    Console.WriteLine($"Digite sua senha: ");
    senha = Console.ReadLine();
}
Console.WriteLine($"Login efetuado com suceso!");


