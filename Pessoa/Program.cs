
Pessoa pessoa = PreencherPessoa();

MostrarPessoa(pessoa);

Pessoa pessoa1 = PreencherPessoa();

MostrarPessoa(pessoa1);

Pessoa pessoa2 = PreencherPessoa();


MostrarPessoa(pessoa2);

Pessoa PreencherPessoa()
{
    Pessoa pessoa = new Pessoa();

    pessoa.nome = pessoa.DefinirNome();
    pessoa.idade = pessoa.DefinirIdade();
    pessoa.sobrenome = pessoa.DefinirSobrenome();

    Console.WriteLine("Informw au telefone");
    pessoa.DefinirTelefone(Console.ReadLine());

    Console.WriteLine("Informw au celular");
    pessoa.DefinirCelular(Console.ReadLine());

    Console.WriteLine("Informw au rmail");
    pessoa.DefinirEmail(Console.ReadLine());

    return pessoa;
}

void MostrarPessoa(Pessoa pessoa)
{
    Console.ReadKey();
    pessoa.MostrarDados();
    Console.ReadKey();

}