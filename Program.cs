using System.Collections;
using System.IO;
using System.Diagnostics;
using System;
List<string> Nomes = new list<string>();
Nomes.Add("José");
Nomes.Add("Thiago");
Nomes.Add("Gabriela");
Nomes.Add("Hugo");
Nomes.Add("Carolina");
Nomes.Add("Letícia");
Nomes.Add("Rosana");
Nomes.Add("Adriana");
Nomes.Add("André");
Nomes.Add("Fernanda");
List<string> Sobrenomes = new list<string>();
Sobrenomes.Add("Pinto");
Sobrenomes.Add("Ribeiro");
Sobrenomes.Add("Fernandes");
Sobrenomes.Add("Silva");
Sobrenomes.Add("Oliveira");
Sobrenomes.Add("Nunes");
Sobrenomes.Add("Dhar");
Sobrenomes.Add("Bittencourt");
Sobrenomes.Add("Alves");
Sobrenomes.Add("Neves");
List<string> Adjetivos = new list<string>();
Adjetivos.Add("Amazing");
Adjetivos.Add("Great");
Adjetivos.Add("Awesome");
Adjetivos.Add("Unstoppable");
Adjetivos.Add("Legendary");
Adjetivos.Add("Unbelivable");
Adjetivos.Add("Good");
Adjetivos.Add("Godlike");
Adjetivos.Add("Perfect");
Adjetivos.Add("Beautiful");
List<string> Caracteres = new list<string>();
Caracteres.Add("!");
Caracteres.Add("@");
Caracteres.Add("#");
Caracteres.Add("$");
Caracteres.Add("%");
Caracteres.Add("¨");
Caracteres.Add("&");
Caracteres.Add("*");
Caracteres.Add("(");
Caracteres.Add(")");
List<string> Senhas = new list<string>();
Senhas.Add("Qwer");
Senhas.Add("tyu");
Senhas.Add("iop");
Senhas.Add("asd");
Senhas.Add("fgh");
Senhas.Add("jkl");
Senhas.Add("zxc");
Senhas.Add("vbn");
Senhas.Add("mko");
Senhas.Add("qed");
Random rnd = new Random();
int Nrnd = rnd.Next(Nome.Count);
int SNrnd = rnd.Next(Sobrenomes.Count);
int Arnd = rnd.Next(Adjetivos.Count);
int Crnd = rnd.Next(Caracteres.Count);
int Srnd = rnd.Next(Senhas.Count);
Console.WriteLine(Nomes[Nrnd]);
Console.WriteLine(Sobrenomes[SNrnd]);
Console.WriteLine(Adjetivos[Arnd]);
Console.WriteLine(Caracteres[Crnd]);
Console.WriteLine(Senhas[Srnd]);



/*

Console.WriteLine("oi");


using ProjetoSENAI.Model;

 Usuario usuario = new Usuario();
usuario.Nome = "Rogerinho Fumaça";
usuario.Senha = "senhaforti";


context.Add(usuario);
context.SaveChanges();

ExemploSenaiContext db = new ExemploSenaiContext();

while(true)
{
Console.WriteLine("O que deseja fazer? 1 - Logar, " + "2 - Registrar ou 3 - Sair");
string num = Console.ReadLine();

if(num == "1")
{
    Console.WriteLine("Digite o seu nome: ");
    string nome = Console.ReadLine();
    
    Usuario expectedUser = null;

    foreach(Usuario usuario in db.Usuarios)
    {
        if (usuario.Nome == nome)
        {
            expectedUser = usuario;
        }
        
    }

    if(expectedUser == null)
    {
        Console.WriteLine("Não existe usuário com esse nome.");
        Console.ReadKey(true);
        Console.Clear();
        continue;
    }

    Console.WriteLine("DIgite a sua senha: ");
    string senha = Console.ReadLine();

    if(expectedUser.Senha != senha)
    {
        Console.WriteLine("Senha inválida.");
        Console.ReadKey(true);
        Console.Clear();
        continue;
    }

    Console.Clear();
}
else if(num == "2")
{
    Usuario usuario = new Usuario();
    
    Console.WriteLine("Digite o seu nome: ");
    usuario.Nome = Console.ReadLine();

    Console.WriteLine("DIgite a sua senha: ");
    usuario.Senha = Console.ReadLine();

    context.Add(usuario);
    context.SaveChanges();

    Console.Clear();
}
else if (num == "3")
{
    break;
}
else
{
    Console.Clear();
    Console.WriteLine("Operação Inválida");
}
}





Func<string> func = MinhaFuncao;


string resultado = func();

Console.WriteLine(resultado)

string ReverterString(string s)
{
    return string.Concat(s.Reverse());
}


void MinhaFuncao(string s)
{
    Console.WriteLine("Olá mundo");
    Console.WriteLine(s);
    Console.WriteLine("Olá mundo");
}

void MinhaFuncao2()
{
    
    Console.WriteLine("Banana");

}

*/