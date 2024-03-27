
using System.Reflection.Metadata;

Console.WriteLine("digite seu nome: ");

string? nome = Console.ReadLine();

Console.WriteLine("O nome digitado foi: " + nome);

Console.WriteLine("digite um numero inteiro");
int valor2 = Convert.ToInt32(Console.ReadLine());
//por ser uma linguagem fortemente tipada se faz necessario o uso de um conversor de tipo de dado

Console.WriteLine("valor digitado = " + valor2);

float x = 1f/3f;
double y = 1d/3d;

Console.WriteLine(x + "e" + y);

// para indicar o tipo de numero usado precisamos digitar o sufixo adequado, o padrao e double

bool resultado;

if (valor2 > 10)
{
    resultado = true;
    Console.WriteLine(resultado);
}
else
{
    resultado= false;
    Console.WriteLine(resultado);
}

//bool padrao = false

char letra1 = 'b';

Console.WriteLine(letra1);
//char tem de ser representado com aspas simples, pode ser um caractere solo ou sua formatacao unicode

//tipo object e dynamic sao tipos base (dynamic se resolve em tempo de execucao)

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);
// valor padrao 01010001 000000

DateTime dataNasc = new DateTime(2000, 02, 22);
Console.WriteLine(dataNasc);
//caso nao seja iserido o horario padrao e meia noite
Console.WriteLine(dataNasc.DayOfYear);

Nullable<int> a = null;
int? b = null;


// sao duas formas de se declarar uma variavel que pode ser nula 


Console.WriteLine($"{nome} nasceu em {dataNasc}");

//interpolacao /\

Console.WriteLine("{0} nasceu em {1}", nome, dataNasc);

//placeholder

Console.WriteLine(nome + " nasceu em " + dataNasc);

//concatenacao

