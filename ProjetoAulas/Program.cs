// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Primeiro Programa!");
// variavel int
int idade = 33;
Console.WriteLine(idade);
//variavel string
string nomePessoa = "Carlos Alberto";
Console.WriteLine(nomePessoa);
//variavel decimal,double e float
decimal valor = 233.5m;
double valorDouble = 233.5;
float valorFloat = 233.5f;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);
// char , var, bool
char flag = 'C';
var idadeNova = 21;
bool ativo = false;
ativo = true;
Console.WriteLine(flag);
Console.WriteLine(idadeNova);
Console.WriteLine(ativo);

//const variavel nome e valor
const int nota = 9 ;
Console.WriteLine(nota);*/

/*Operadores aritiméticos com C#//
int numero1 = 3;
int numero2 = 2;
//var soma = 1 + 2;
//Console.WriteLine(soma);

var some = numero1 + numero2;
Console.WriteLine(some);

int subtraia = numero1 - numero2;
Console.WriteLine(subtraia);

int multplique = numero1 * numero2;
Console.WriteLine(multplique);

int divisao = numero1 / numero2;
Console.WriteLine(divisao);

int equacao = (numero1 * numero1) / 5 + (numero1 - 10);
Console.WriteLine(equacao)

int numero1 = 3;
int numero2 = 2;
int numero3 = 4;
int numero4 = 5;
valor = problema;
const int (valor) =  (numero3 * numero1) + numero4 -(numero2);
Console.WriteLine(problema);

//operadores de relacionais

bool igual = 1 == 2;
Console.WriteLine(igual);

bool maior = 1 > 2;
Console.WriteLine(maior);

bool menor = 1 < 2;
Console.WriteLine(menor);

bool maiorOuIgual = 1 >= 2;
Console.WriteLine(maiorOuIgual);

bool menorOuIgual = 1 <= 2;
Console.WriteLine(menorOuIgual);

bool diferente = 1 != 2;
Console.WriteLine(diferente);*/

//  OPeradores Lógicos // && = eE(AND) RETORNA BOOLEAN// "||"  OU (OR) RETORNA O VALOR DE UM OU DE OUTRO //
// ""!" NEGAÇÃO 

//int numero1 = 3;
//int numero2 = 2;

/*var valido = numero1 > numero2 && 4 > 7;
Console.WriteLine(valido);

var valido2 = numero2 > 10 || 4 > 7;
Console.WriteLine(valido2);

var valido3 = !(numero2 > 10);
Console.WriteLine(valido3);*/

// 0pertadores Ternários//? :

/*bool ativo = true;
string status = ativo ? "Cadastro ativo" : "Cadastro Inativo";
Console.WriteLine(status);

bool ativo = false;
string status = !ativo ? "Cadastro ativo" : "Cadastro Inativo";
Console.WriteLine(status);

bool ativo = false;
string status = ativo ? "Cadastro ativo" : "Cadastro Inativo" : "Cadastro inexistente"
Console.WriteLine(status);*/

// FUNÇÕES//

/*EscreverNome();

void EscreverNome(){
    var soma = somaValores();
    var nome = NomeCompleto();

    Console.WriteLine(nome);
    Console.WriteLine(soma);

}

string NomeCompleto()
{
    string primeiroNome = "Carlos";
    string segundoNome = "Alberto";
    return primeiroNome + " " + segundoNome;
}
int somaValores()
{
    return 8 + 5;
}*/

////Função que recebe parametro/////

var soma = SomaValores(3, 6);
Console.WriteLine(soma);

var nome = NomeEIdadade("Carlos", 21);
Console.WriteLine(nome);

int SomaValores (int a, int b){
    return a + b;
}

string NomeEIdadade (string nome, int idade){
    return "Meu nome é" + nome + "e tenho " + idade + " anos";
}







