using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("O álbum pertece a qual banda? ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} da banda {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}