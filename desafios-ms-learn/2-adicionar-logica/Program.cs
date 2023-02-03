Console.OutputEncoding = System.Text.Encoding.UTF8;

/*

** ROTEIRO: Adicione lógica aos seus aplicativos com C#


DESAFIO 1. Neste desafio, você implementará regras de negócios que restringem o acesso a usuários com base nas respectivas permissões e nível. Você exibirá uma 
mensagem diferente para cada usuário, dependendo das respectivas permissões e nível.

- Adicionar código como um ponto de partida. Para testar a lógica de sua expressão booliana, use o código a seguir de dados de exemplo.

CÓDIGO:

string permission = "Admin|Manager";
int level = 55;

- Importante - Para determinar se o valor da variável permission contém um dos valores de permissão que você verificará nas "regras de negócio", use o método 
auxiliar Contains() de uma cadeia de caracteres. Por exemplo, permission.Contains("Admin") retornaria true.

– Implementar regras de negócios:
1. Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
Welcome, Super Admin user.

2. Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
Welcome, Admin user.

3. Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
Contact an Admin for access.

4. Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
You do not have sufficient privileges.

5.Se o usuário não for um administrador nem um gerente, exiba a mensagem:
You do not have sufficient privileges.

Ao executar o código, incluindo os dados de exemplo da Etapa 2, você deverá ver a seguinte saída:

- Saída esperada: Welcome, Admin user.
*/

string permission = "Admin|Manager";
int level = 55;

if(permission.Contains("Admin") && level > 55)
{
	Console.WriteLine("Welcome, Super Admin user.");
}
else if(permission.Contains("Admin") && level <= 55)
{
	Console.WriteLine("Welcome, Admin user.");
}
else if(permission.Contains("Manager") && level >= 20)
{
	Console.WriteLine("Contact an Admin for access.");
}
else if(permission.Contains("Manager") && level < 20)
{
	Console.WriteLine("You do not have sufficient privileges.");
}
else{
	Console.WriteLine("You do not have sufficient privileges.");
}

Console.WriteLine("-----------------------------------");

/*
DESAFIO 2. Use o que você aprendeu neste módulo para corrigir este código mal escrito. Há muitas melhorias que você pode fazer. Boa sorte!

CÓDIGO: 

int[] numbers = { 4, 8, 15, 16, 23, 42 };
foreach (int number in numbers)
{
    int total;
    total += number;
    if (number == 42)
    {
       bool found = true;
    }
}
if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");


SAÍDA ESPERADA:

Set contains 42
Total: 108
*/

int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
    	Console.WriteLine("Set contains 42");
    }
}
Console.WriteLine($"Total: {total}");

Console.WriteLine("-----------------------------------");

/*
DESAFIO 3. Suponha que trabalhamos para uma loja de lembranças em uma cidade universitária que vende camisetas, moletons e outros presentes com o logotipo e 
as cores da instituição. Um relatório mensal de vendas usa a descrição completa, assim como a SKU (Unidade de Manutenção de Estoque) dos produtos vendidos. 
Pediram que reescrevêssemos determinadas partes do código para ficarem mais legíveis. 
- Uma das tarefas é simplificar a conversão de um SKU em uma descrição usando a instrução switch.
O código a seguir converte um SKU em uma descrição de formato longo (por exemplo, o SKU 01-MN-L é um "suéter grande bordô").

SAÍDA ESPERADA: Product: Large Maroon Sweat shirt

CÓDIGO:

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
	case "01":
    type = "Sweat shirt";
		break;
	case "02":
    type = "T-Shirt";
		break;
	case "03":
    type = "Sweat pants";
		break;
	default:
    type = "Other";
		break;
}

switch (product[1])
{
	case "BL":
    color = "Black";
		break;
	case "MN":
    color = "Maroon";
		break;
	default:
    color = "White";
	break;
}

switch (product[2])
{
	case "S":
    size = "Small";
		break;
	case "M":
    size = "Medium";
		break;
	case "L":
    size = "Large";
		break;
	default:
    size = "One Size Fits All";
		break;
}

Console.WriteLine($"Product: {size} {color} {type}");
Console.WriteLine("-----------------------------------");

/*
DESAFIO 4. O FizzBuzz é um conhecido desafio de codificação e uma pergunta de entrevista. Ele exercita sua compreensão do for, do if, do operador de resto % e 
do comando da lógica básica.

Regras do FizzBuzz:

- Valores de saída de 1 a 100, um número por linha.
- Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
- Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
- Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número.

- Não importa como você fará isso; o código deverá produzir a saída a seguir. Mostraremos apenas os primeiros 22 valores. Sua saída deverá continuar até 100.

SAÍDA ESPERADA:
1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
*/

for (int i = 1; i <= 100; i++)
{
	if((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i} - FizzBuzz");
	else if(i % 3 == 0) Console.WriteLine($"{i} - Fizz");
	else if(i % 5 == 0) Console.WriteLine($"{i} - Buzz");
	else Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------");

/*
DESAFIO 5. Desafio de batalha em RPG
- Na maioria das funções que desempenham jogos, o personagem do jogador batalha contra personagens não controlados por outros jogadores, que geralmente são 
monstros ou vilões. Normalmente, uma batalha consiste em cada personagem gerar um valor aleatório usando dados e esse valor é subtraído da pontuação de 
integridade do adversário. Quando a integridade de um personagem chega a zero, ele morre ou perde.
- Neste desafio, vamos reduzir essa interação à sua essência. Um herói e um monstro começam com a mesma pontuação de integridade. Durante a rodada do herói, 
ele gerará um valor aleatório que será subtraído da integridade do monstro. Se a integridade do monstro for maior que zero, ela terá sua rodada e atacará o herói. 
Desde que tanto o herói quanto o monstro tenham integridade maior que zero, a batalha continuará.
Implemente as seguintes regras para o jogo:

Regras do Jogo:

- O herói e o monstro começarão com dez pontos de integridade.
- Todos os ataques serão um valor entre 1 e 10.
- O herói atacará primeiro.
- Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
- Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
- Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
- Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
- Imprima quem foi o vencedor.

O mais importante é:
- Você precisa usar a instrução do-while ou a instrução while.

Não importa como você fará isso; o código deverá produzir uma saída semelhante:

SAÍDA ESPERADA:

Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/
int heroHP = 10;
int monsterHP = 10;

Random points = new Random();
int attack;

while((monsterHP > 1) || (heroHP > 1))
{
	attack = points.Next(11);
	monsterHP -= attack;
	Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHP} health.");

	if (monsterHP > 1)
	{
		attack = points.Next(11);
		heroHP -= attack;
		Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health.");
		if(heroHP < 1) 
		{
			Console.WriteLine("Monster wins!");
			break;
		}
	}
	else
	{
		Console.WriteLine("Hero wins!");
		break;
	}

}

Console.WriteLine("-----------------------------------");
