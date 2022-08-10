using System.Collections;
using System.IO;
using System.Diagnostics;
using System;


Console.WriteLine("oi");

/*

using ProjetoSENAI.Model;

/* Usuario usuario = new Usuario();
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

/*
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