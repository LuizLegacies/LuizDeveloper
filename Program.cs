// See https://aka.ms/new-console-template for more information


using System.Xml;
using Notas;

Console.WriteLine("Hello World!");

var gerenciador = new Gerenciador();

while(true)
{
    Console.WriteLine("1. Adicionar nota");
    Console.WriteLine("2. Exibir notas");
    Console.WriteLine("3. Sair");

    var opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Digite a descrição da nota:");
            var titulo = Console.ReadLine();
            gerenciador.Adicionar(titulo);

            break;
        case "2":
            gerenciador.Exibirtodas();
            
            break;
        case "3":
            return;
    }
}