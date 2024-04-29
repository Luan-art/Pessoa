using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string nome;
    public string sobrenome;
    public int idade;
    public string telefone;
    public string celular;
    public string email;



    public Pessoa()
    {


    }

    public string DefinirNome()
    {
        Console.WriteLine("Informe nome desejado");
        return Console.ReadLine();
    }

    public string DefinirSobrenome()
    {
        Console.WriteLine("Informe sobrenome desejado");
        return Console.ReadLine();
    }

    public int DefinirIdade()
    {
        Console.WriteLine("Informe a idade desejada ");
        return int.Parse(Console.ReadLine());
    }

    public void DefinirTelefone(string telefone)
    {
        this.telefone = telefone;
    }


    public void DefinirCelular(string celular)
    {
        this.celular = celular;
    }


    public void DefinirEmail(string email)
    {
        this.email = email;

    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {nome}", this.nome);
        Console.WriteLine($"Sobrenom: {sobrenome}", this.sobrenome);
        Console.WriteLine($"Idade: {idade}", this.idade);
        Console.WriteLine($"Telefone: {telefone}", this.telefone);
        Console.WriteLine($"Celular: {celular}", this.celular);
        Console.WriteLine($"Email: {email}", this.email);

    }






}




