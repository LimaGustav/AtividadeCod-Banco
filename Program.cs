// See https://aka.ms/new-console-template for more information


using CodificacaoAT.Classes;
Console.Clear();
Console.WriteLine(@"

    1 - Cadastrar PJ
    2 - Sair do Sistema
");

PessoaJuridica metodosPJ = new PessoaJuridica();
string opcao = Console.ReadLine()!;

if (opcao == "1")
{
    PessoaJuridica pj = new PessoaJuridica();

    Console.WriteLine("Informe o nome da PJ: ");
    pj.Nome = Console.ReadLine();

    Console.WriteLine("Informe o rendimento da PJ: ");
    pj.Rendimento = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Informe o CNPJ da PJ: ");
    pj.CNPJ = Console.ReadLine();


    metodosPJ.Inserir(pj);

    Console.WriteLine("\n\nPessoa Juridica cadastrada com sucesso!");
}
else if (opcao == "2")
{
    Console.Clear();

    Console.WriteLine("Obrigado por utilizar o nosso sistema");
}
if (opcao != "1" && opcao != "2")
{
    Console.Clear();

    Console.WriteLine("Opção inválida, tente novamente");
}