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
