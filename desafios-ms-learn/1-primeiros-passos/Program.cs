Console.OutputEncoding = System.Text.Encoding.UTF8;

/*

** ROTEIRO: Dê seus primeiros passos com o C#

DESAFIO 1. Use as duas técnicas diferentes para imprimir as duas linhas da saída. Em outras palavras, você aprendeu a exibir uma mensagem em apenas uma linha 
de código e exibir uma mensagem usando várias linhas de código. Use as duas técnicas para esse desafio. Não importa qual técnica você aplicará a qual linha e 
não importa por quantas maneiras você dividirá uma das mensagens em várias linhas de código. Isso fica a seu critério.

- Saída esperada:

This is the first line.
This is the second line.
*/

Console.WriteLine("This is the first line.");
Console.Write("This is ");
Console.WriteLine("the second line.");

Console.WriteLine("-----------------------------------");

/*
DESAFIO 2. Armazene os seguintes valores da saída em variáveis:
	Bob
	3
	34.4
- Essas variáveis devem receber nomes que reflitam sua finalidade.
- Selecione o tipo de dados correto para cada uma das variáveis com base no tipo de dados que ela manterá.
- Por fim, você combinará as variáveis com cadeias de caracteres literais passadas para uma série de comandos Console.Write() para formar a mensagem completa.

- Saída esperada: Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.
*/

string name = "Bob";
int inbox = 3;
double temperature = 34.4;

Console.Write("Hello, ");
Console.Write(name + "! You have ");
Console.Write(inbox);
Console.Write(" in your inbox. ");
Console.Write("The temperature is ");
Console.WriteLine(temperature + " celsius.");


Console.WriteLine("-----------------------------------");

/*
DESAFIO 3. Neste desafio, você imprimirá instruções para o usuário final para que ele saiba onde seu aplicativo gerará arquivos de dados. 
Na verdade, não vamos criar nenhum arquivo. Estamos interessados apenas em exibir instruções formatadas na janela do console.

- Você usará o que aprendeu sobre sequências de escape de caractere, cadeias de caracteres textuais, Unicode e interpolação de cadeias para fornecer instruções 
em inglês e russo.

- Comece a resolver o desafio com as duas linhas de código a seguir. 
Você não pode alterar essas duas linhas de código.

CÓDIGO:

string projectName = "ACME";

string russianMessage = 
"\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


- A variável projectName será usada duas vezes na saída desejada.
- A variável russianMessage contém a mensagem "Exibir saída russa" em russo. Você precisa usar essa variável em seu código que imprime a mensagem.

- Você só pode usar o método Console.WriteLine() ou Console.Write() duas vezes.

- Para concluir esse desafio, seu código deve produzir a saída a seguir:

View English output:
		c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
		c:\Exercise\ACME\ru-RU\data.txt
*/

string projectName = "ACME";

string russianMessage = 
"\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine($@"View English output:
	c:\Exercise\{projectName}\data.txt");

Console.WriteLine($"{russianMessage}:\n\t\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt");


Console.WriteLine("-----------------------------------");

/*
DESAFIO 4. Neste desafio, você escreverá um código que usará uma fórmula para converter uma temperatura de graus Fahrenheit para Celsius. 
Você imprimirá o resultado em uma mensagem formatada para o usuário.

-Para converter temperaturas de graus Fahrenheit para Celsius, primeiro subtraia 32 e, em seguida, multiplique por cinco nonos (5/9).

CÓDIGO:
int fahrenheit = 94;

- Por fim, você combinará as variáveis com cadeias de caracteres literais passadas para uma série de comandos Console.WriteLine() para formar a mensagem completa.

- Saída esperada:  The temperature is 34.444444444444444444444444447 Celsius.
*/

int fahrenheit = 94;
double celsius = (fahrenheit - 32) * 5.0/9;

Console.WriteLine($"The temperature is {celsius} Celsius");

Console.WriteLine("-----------------------------------");

/*
DESAFIO 5. Neste exercício, você usará o IntelliSense ou o docs.microsoft.com para localizar e chamar um método que retorna o maior de dois números.
-Use o código a seguir com o ponto de partida do seu código.

int firstValue = 500;
int secondValue = 600;
int largerValue;

Console.WriteLine(largerValue);

- Seu trabalho é pesquisar e preencher a linha de código ausente que chama um método da classe Math que aceitará dois valores e retornará o maior deles na 
variável largerValue, que será impressa no console.

- Saída esperada: 600
*/

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Console.WriteLine("-----------------------------------");

/*
DESAFIO 6. Foi solicitado que você adicionasse um recurso ao software de sua empresa. O recurso destina-se a melhorar a taxa de renovação das assinaturas do 
software. Sua tarefa é exibir uma mensagem de renovação quando um usuário fizer logon no sistema de software e receber a notificação de que a assinatura está 
prestes a ser encerrada. Você precisará adicionar um par de instruções de decisão para adicionar corretamente a lógica de ramificação ao aplicativo para atender 
aos requisitos.

- Use duas instruções IF para implementar as seguintes regras de negócios (ramificação ou aninhamento três na primeira instrução IF).
Regra 1. Se a assinatura do usuário expirar em dez dias ou menos, será exibida a mensagem:
Your subscription will expire soon. Renew now!

Regra 2. Se a assinatura do usuário expirar em cinco dias ou menos, será exibida a mensagem: 
(Substitua _ pelo valor armazenado na variável daysUntilExpiration.)
Your subscription expires in _ days.
Renew now and save 10%!

Regra 3. Se a assinatura do usuário expirar em um dia, será exibida a mensagem:
Your subscription expires within a day!
Renew now and save 20%!

Regra 4. Se a assinatura do usuário tiver expirado, será exibida a mensagem:
Your subscription has expired.

Regra 5. Se a assinatura do usuário não expirar em dez dias ou menos, não será exibida nenhuma mensagem.

- Precisa usar todas as variáveis em seu código.
*/

//CÓDIGO:

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if(daysUntilExpiration < 1) 
{
	Console.WriteLine("Your subscription has expired.");
}
else if(daysUntilExpiration == 1) 
{	
	discountPercentage = 20;
	Console.WriteLine("Your subscription expires within a day!.");
}
else if(daysUntilExpiration <= 5) 
{
	discountPercentage = 10;
	Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if(daysUntilExpiration <= 10) 
{
	Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0)
{
	Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

Console.WriteLine("-----------------------------------");

/*
DESAFIO 7. Decidimos escrever código para armazenar IDs de pedidos possivelmente fraudulentos. Esperamos encontrar pedidos fraudulentos o quanto antes e 
sinalizá-los para uma análise mais profunda.

- Nossa equipe detectou um padrão. Pedidos que começam com a letra "B" têm um número de fraudes 25 vezes maior que o normal. Vamos escrever um novo código 
para gerar a ID de novos pedidos, em que a ID do pedido começa com a letra "B". Isso será usado por nossa equipe de fraudes para investigar ainda mais.

- Declarar e inicializar uma nova matriz para conter IDs de pedidos falsas. Veja os dados da ID de pedido falsa que deve ser usada para inicializar a matriz.
B123
C234
A345
C15
B177
G3003
C235
B179

- Iterar em cada elemento da matriz. Use uma instrução foreach para iterar em cada elemento da matriz que você acabou de declarar e inicializar.

- Se a ID de Pedido falsa começar com "B", imprima-a na saída. Avalie cada elemento da matriz. Identifique e imprima para gerar as IDs de pedidos possivelmente 
fraudulentas procurando os pedidos que começam com a letra "B". 
-Para determinar se um elemento começa ou não com a letra "B", use o método String.StartsWith(). Veja um exemplo simples de como usar o método 
String.StartsWith() para poder empregá-lo em seu código:

string name = "Bob";
if (name.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}

-Saída esperada: 
B123
B177
B179
*/

string[] pedidos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string id in pedidos)
{
	if(id.StartsWith("B"))
		Console.WriteLine(id);
}

Console.WriteLine("-----------------------------------");

/*
DESAFIO 8. Seu objetivo é fazer melhorias em um código mal formatado e mal comentado para melhorar sua legibilidade.

- A finalidade de alto nível desse código é inverter uma cadeia de caracteres e contar o número de vezes que um caractere específico é exibido.
- O código sofre de muitos problemas que diminuem drasticamente sua legibilidade.
- Faça melhorias no código para melhorar sua legibilidade.

Execute, copie ou digite a seguinte listagem de código para que ela apareça no Editor do .NET:

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/

// Inverter uma string e contar qunatas vezes a letra "o" aparece.

string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);

int count = 0;
foreach (char letter in charMessage) 
{ 
	if (letter == 'o') 
		count++;
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");

Console.WriteLine("-----------------------------------");
