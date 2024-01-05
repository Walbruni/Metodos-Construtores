using MetodosConstrutores.Models;
using System.Globalization; // para alterar o valor monetário

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // para alterar a localização do sistema e modificar a formatação do valor monetário 


Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Walbruni");

Pessoa p2 = new Pessoa(nome: "Emanuella", sobrenome: "Cacau");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


// concatenação de valores
string numero1 = "10";
string numero2 = "20";
// string + string é concatenação
// int + int é uma soma de valores
// string + int é concatenação, pois o valor do int assume o tipo string 
string resultado = numero1 + numero2;

Console.WriteLine(resultado);


// formatação de valores monetários
decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}"); // o sinal de :C após a interpolação da string significa a formatação para a moeda do seu sistema 
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // para formata o codigo sem precisar mudar a localização do sistema 
// Console.WriteLine(valorMonetario.ToString("C1")); // o numero após o C indica a quantidade de casas decimais a ser apresentado em tela 

// representando porcentagem
double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

// valor personalizado
int num = 123456;
Console.WriteLine(num.ToString("##-##-##")); // cada simbolo representa um digito e o traço é o separador 


// DateTime
DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // personalizando a data
// Console.WriteLine(data.ToShortDateString()); // para que o horario nao seja exibido 
// Console.WriteLine(data.ToShortTimeString()); // para que seja exibido somente as horas 

// convertendo string para o tipo datetime (para uma data válida) e validando seu retorno 
string dataString = "2021/04/12 12:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dat);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso. Data: {dat}");
} 
else 
{
    Console.WriteLine($"{dataString} não é uma data válida");
}


// tratamento de erro (para que seja exibido em tela e seu codigo nao pare de funcionar)
try
{
    // arquivo de leitura
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // array de strings, pois cada linha do arquivo é uma string que retorna um array 

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }   
// especializando as exceptions (os catch somente sao executados caso ocorra o erro)
} catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho de pasta não encontrado" + ex.Message);
}
catch(Exception ex) // exception generica 
{   
   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}"); 
}
// vem logo apos o catch e serve para executar um bloco de codigo sempre que ocorrer o final da execução, independente de acontecer a exceção ou não 
finally
{
    Console.WriteLine("Chegou aqui");
}


// usando o throw
new ExemploExcecao().Metodo1();


// Queue (Fila)
Queue<int> fila = new Queue<int>(); // fila de inteiros 

fila.Enqueue(2); 
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8); // adiciona elementos ao final da fila 

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // SEMPRE remove o primeiro elemento da fila 


foreach(int item in fila)
{
    Console.WriteLine(item);
}


// Stack (Pilha)
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10); // insere elementos no topo da pilha 

// os elementos sao agrupados SEMPRE no topo, ou seja, a ordem de leitura é sempre debaixo para cima 

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}"); // SEMPRE remove o ultimo elemento que entrou na pilha, ou seja, o elemento do topo 


foreach(int item in pilha)
{
    Console.WriteLine(item);
}


// Dictionary (garante integridade dos dados, pois a chave é unica)
Dictionary<string, string> estados = new Dictionary<string, string>(); // insere dois tipos, nesse exemplo sao duas strings (o primeiro sera a chave e o segundo o valor)

estados.Add("CE", "Ceará");
estados.Add("BA", "Bahia");
estados.Add("PE", "Pernambuco");

Console.WriteLine(estados["PE"]); // para acessar o valor dictionary

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}"); // garante que os elementos sejam unicos, nao sendo possivel add um novo elemento com a mesma chave
}                                                                 // na Key os valores sao unicos, no campo valor pode se repetir, mas nao na chave 

Console.WriteLine("-------");

estados.Remove("BA"); // nao é possivel alterar a chave, apenas remover ou adicionar 
estados["CE"] = "Ceará - valor alterado"; // o valor é possivel alterar 


foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave)) // metodo para verificar se determinada chave ja foi adicionada ou nao 
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}