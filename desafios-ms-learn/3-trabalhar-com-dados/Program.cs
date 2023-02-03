Console.OutputEncoding = System.Text.Encoding.UTF8;

/*
** ROTEIRO: Trabalhar com os dados em C#

DESAFIO 1. Esse desafio força você a dividir os dados dependendo do seu tipo e a concatenar ou adicionar os dados de forma adequada.
-Comece com a seguinte linha de código.

CÓDIGO:

string[] values = { "12.3", "45", "ABC", "11", "DEF" };


Adicione todo o código necessário para implementar as seguintes regras de negócio:

Regras de negócio:

Regra 1: se o valor for alfanumérico, concatene-o para formar uma mensagem

Regra 2: se o valor for numérico, adicione-o ao total

Regra 3: verifique se o resultado corresponde à seguinte saída:

SAÍDA ESPERADA:

Message: ABCDEF
Total: 68.3
*/

string[] values = { "12,3", "45", "ABC", "11", "DEF" };
double sum = 0.0;
double num = 0.0;
string concat = "";

foreach(var value in values)
{
	if(double.TryParse(value, out num)) sum += num;
	else concat += value;

}
Console.WriteLine("Message: " + concat);
Console.WriteLine("Total: " + sum);
Console.WriteLine("-----------------------------------");

/*
DESAFIO 2. O desafio a seguir forçará você a entender as implicações da conversão cast de valores considerando o impacto de conversões de restrição e expansão.
- Substitua os comentários de código pelo seu próprio código para resolver o desafio.

CÓDIGO:

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

SAÍDA ESPERADA:

Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3583333
*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
Console.WriteLine("-----------------------------------");

/*
DESAFIO 3. Esse desafio forçará você a decompor um problema maior em vários miniproblemas e, em seguida, usar as várias ideias deste módulo para resolver 
cada miniproblema.

CÓDIGO:

string pangram = "The quick brown fox jumps over the lazy dog";

- Escreva o código necessário para inverter as letras de cada palavra no lugar e exibir o resultado. Em outras palavras, não basta inverter todas as letras 
na variável pangram. Em vez disso, você precisará inverter apenas as letras de cada palavra, mas imprimir a palavra invertida em sua posição original na mensagem.

- Se você tiver êxito, deverá ver a saída a seguir.

SAÍDA ESPERADA: ehT kciuq nworb xof spmuj revo eht yzal god

- Importante: Esse é um desafio particularmente difícil. Você precisará combinar muitos dos conceitos aprendidos neste exercício, 
incluindo o uso de Split(), ToCharArray(), Array.Reverse() e String.Join(). Você também precisará criar várias matrizes e, pelo menos, uma instrução de iteração.

*/
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");
string newWord;
string text = "";

foreach (var item in words)
{
	char[] letters = item.ToCharArray();
	Array.Reverse(letters);
	
	newWord = String.Join("", letters);
	text += newWord + " ";
}
Console.WriteLine(text);

Console.WriteLine("-----------------------------------");

/*
DESAFIO 4. Anteriormente, decidimos escrever um código para armazenar IDs de pedidos possivelmente fraudulentos. Esperamos encontrar esses pedidos fraudulentos 
o quanto antes e sinalizá-los para uma análise mais profunda.

- Nossa equipe encontrou um padrão: pedidos que começam com a letra "B" têm fraudes 25 vezes mais que o normal. Nosso trabalho é escrever um novo código que 
gerará a ID de novos pedidos, em que a ID do pedido começa com a letra "B". Isso será usado por nossa equipe de fraudes para uma investigação ainda detalhada.

- Usando o código abaixo como ponto de partida, você precisará analisar as IDs do pedido de uma cadeia de caracteres que contém uma sequência de pedidos de 
entrada (o orderStream). Em seguida, você imprimirá cada ID do pedido que começa com a letra "B".

- Aqui vai uma dica: ao executar um loop em cada elemento da matriz, você precisará de uma instrução de decisão. A instrução de decisão precisará usar um 
método na classe de cadeia de caracteres para determinar se uma cadeia de caracteres começa com uma letra específica.

CÓDIGO:
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

SAÍDA ESPERADA:
B123
B177
B179
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderID = orderStream.Split(",");

foreach (var id in orderID)
{
	if(id.StartsWith("B"))
		Console.WriteLine(id);
}

Console.WriteLine("-----------------------------------");

/*
DESAFIO 5. No início deste módulo, descrevemos o cenário de trabalho em um departamento de marketing de uma empresa de serviços financeiros. Para promover os 
produtos de investimento mais recentes da empresa, enviaremos milhares de cartas personalizadas para os clientes existentes da nossa empresa. Nosso trabalho é 
escrever código C# que mesclará informações personalizadas sobre o cliente. A carta conterá informações, como o portfólio existente, e comparará seus retornos 
atuais com retornos projetados se o cliente precisar investir no uso dos nossos novos produtos.
- Nossos escritores escolheram a seguinte cópia de marketing de exemplo. Veja a saída desejada (usando dados fictícios da conta do cliente).

SAÍDA ESPERADA:

Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00


- Use seu novo conhecimento adquirido sobre formatação de cadeia de caracteres para criar um aplicativo que possa mesclar e formatar o conteúdo adequado 
considerando a saída de exemplo acima. Preste muita atenção no espaço em branco e represente com precisão esse formato exato usando o C#.

- Veja as regras do desafio.
- 
Substitua os comentários do código pelo seu próprio código de formatação de cadeia de caracteres.
- Você não pode excluir nenhum código existente, exceto os comentários.

CÓDIGO:

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);
*/

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;


Console.WriteLine($@"Dear {customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.

Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");

Console.WriteLine("\nHere's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(15);
comparisonMessage += String.Format("{0:C}", currentProfit) + "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(15);
comparisonMessage += String.Format("{0:C}", newProfit);

Console.WriteLine(comparisonMessage);

Console.WriteLine("-----------------------------------");

/*
DESAFIO 6. Neste desafio, você trabalhará com uma cadeia de caracteres que contém um fragmento de HTML. Você extrairá dados do fragmento HTML, substituirá 
parte de seu conteúdo e removerá outras partes de seu conteúdo para obter a saída desejada.

- Dado o ponto de partida na lista de códigos a seguir, você adicionará código para extrair, substituir e remover partes do valor input para produzir a 
saída desejada.

- Você só pode adicionar código à lista de códigos do ponto de partida. Não altere as declarações da variável. Todo o seu trabalho deve ficar abaixo do 
comentário // Your work here.

- Você executará três operações na entrada usando as ferramentas e as técnicas aprendidas neste módulo.

- Defina a variável quantity como o valor extraído entre as marcas <span> e </span>.
- Defina a variável output como o valor de entrada e, em seguida, remova as marcas <div> e </div>.
- Substitua o caractere HTML &trade; por &reg; na variável output.


CÓDIGO:
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);


SAÍDA ESPERADA:

Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int opening = input.IndexOf(openSpan);
int closing = input.IndexOf(closeSpan);

opening += openSpan.Length;
int diference = closing - opening;
quantity = input.Substring(opening, diference);

int openDiv = input.IndexOf(">") + 1;
int closeDiv = input.LastIndexOf("<");

int length = closeDiv - openDiv;
output = input.Substring(openDiv, length);
output = output.Replace("trade", "reg");

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);

Console.WriteLine("-----------------------------------");