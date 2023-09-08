/* using ScreenSound.Modelos;
using ScreenSound.Menus;
using OpenAI_API;
using OpenAI_API.Chat;

OpenAIAPI api = new OpenAIAPI("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"); 
var chat = api.Chat.CreateConversation();
chat.AppendSystemMessage("Resuma a banda Ira! em 1 parágrafo. Adote o estilo informal.");

string response = await chat.GetResponseFromChatbotAsync();
Console.WriteLine(response);

foreach (ChatMessage msg in chat.Messages)
{
	Console.WriteLine($"{msg.Role}: {msg.Content}");
}

Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuExibirBandas());
opcoes.Add(4, new MenuExibirDetalhes());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuAvaliarBanda());

opcoes.Add(0, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para exibir todas as bandas");
    Console.WriteLine("Digite 4 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para avaliar uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibicao = opcoes[opcaoEscolhidaNumerica];
        menuExibicao.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}
 */
//ExibirOpcoesDoMenu();

using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://github.com/guilhermeonrails/api-csharp-songs/blob/main/songs.json");
}