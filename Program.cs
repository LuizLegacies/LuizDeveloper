#region tipos e variaveis 
/*Console.WriteLine("Hello World!");


 var nome = Console.ReadLine();
    Console.WriteLine(nome);

double valorDouble = 15.5;
float  valorFloat = 15.5f;  //f no final
decimal valorDecimal = 15.5m; //m no final 
int valorInteiro = 15;
bool valorBoolean = true;   //true ou false
char valorChar = 'A'; //aspas simples
string valorString = "Aqui é uma string"; //aspas duplas

const double PI = 3.1415; //constante  

Console.WriteLine($"Double: {valorDouble}");
Console.WriteLine($"Float: {valorFloat}");
Console.WriteLine($"Decimal: {valorDecimal}");
Console.WriteLine($"Inteiro: {valorInteiro}");
Console.WriteLine($"Boolean: {valorBoolean}");
Console.WriteLine($"Char: {valorChar}");
Console.WriteLine($"String: {valorString}");    
Console.WriteLine($"Constante: {PI}");
*/

#endregion

#region operadores Aritméticos

/*int a = 10;
int b = 20;

int soma = a + b;
int subtracao = a - b;
int multiplicacao = a * b;
int divisao = a / b;
int modulo = a % b; //resto da divisão

Console.WriteLine($"Soma: {soma}, Subtração: {subtracao}, Multiplicação: {multiplicacao}, Divisão: {divisao}, Módulo: {modulo}");
*/
#endregion

#region operadores Lógicos
/*bool x = true;
bool y = false;

var and = x && y;   //and
var or = x || y;    //or
var notx = !x;       //not
var noty = !y;       //not
Console.WriteLine("x = true, y = false");
Console.WriteLine($"AND: {and}, OR: {or}, NOT X: {notx}, NOT Y: {noty}");
*/
#endregion

#region operadores de comparação
/*var p = 5;
var q = 10;

bool maior = p > q;
bool maiorOuIgual = p >= q;
bool menor = p < q;
bool menorOuIgual = p <= q;
bool igual = p == q;
bool naoIgual = p != q;

Console.WriteLine("p = 5, q = 10");
Console.WriteLine($"Maior: {maior}, Maior ou igual: {maiorOuIgual}, Menor: {menor}, Menor ou igual: {menorOuIgual}, Igual: {igual}, Não igual: {naoIgual}");

*/
#endregion

#region operadores de Igualdade e Atribuição
/*int k = 5;
k = 10; //atribuição

k += 5; //k = k + 5 - 10 + 5 = 15
Console.WriteLine(k);
k -= 3; //k = k - 3 - 15 - 3 = 12
Console.WriteLine(k);
k *= 2; //k = k * 2 - 12 * 2 = 24 
Console.WriteLine(k);
k /= 4; //k = k / 4 - 24 / 4 = 6
Console.WriteLine(k);
k %= 5; //k = k % 5 - 6 % 5 = 1
Console.WriteLine(k);
*/
#endregion

#region Estruturas de condição - if
/*var nota = 50;

if (nota >= 70)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 30)
{
    Console.WriteLine("em recuperacao");
}
else
{
    Console.WriteLine("Reprovado");
}

*/

#endregion 

#region Estruturas de condição - switch
/*var opcao = 4;

switch (opcao)
{
    case 1:
        Console.WriteLine("Opção 1");
        break;
    case 2:
        Console.WriteLine("Opção 2");
        break;
    case 3:
        Console.WriteLine("Opção 3");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
*/
#endregion

#region Matrizes
/*int [] matriz = [1, 2, 3, 4, 5];
int [] matrizVazia = new int[5];

var tamanhoMatriz = matriz.Length;
var dimensaoMatriz = matriz.Rank;

Console.WriteLine($"Tamanho da matriz: {tamanhoMatriz}, Dimensão da matriz: {dimensaoMatriz}");


Array.Sort(matriz);

Array.Reverse(matriz);
*/

#endregion

#region Estruturas de repetição 
/*int [] matriz = {1, 2, 3, 4, 5};

Console.WriteLine("while");
int contador = 0;
while (contador < matriz.Length)
{
    Console.WriteLine(matriz[contador]); //matriz [o] matriz [1] matriz [2] matriz [3] matriz [4]
    contador++;
}
Console.WriteLine("do while");
contador = 0;
do
{
    Console.WriteLine(matriz[contador]);
    contador++;
} while (contador < matriz.Length);

Console.WriteLine("for");
for (int i = 0; i < matriz.Length; i++)
{
    Console.WriteLine(matriz[i]);
}

Console.WriteLine("foreach");
foreach (var item in matriz)
{
    Console.WriteLine(item);
}
*/
#endregion



