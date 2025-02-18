using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas;

internal class RegistrarBanda : MenuBandas
{
    public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
    {
        base.Executar(bandasRegistradas, opcao);
        //ExibirTituloDaOpcao("Registro das bandas");
        //Console.Write("Digite o nome da banda que deseja registrar: ");
        //string nomeDaBanda = Console.ReadLine()!;
        //Banda banda = new Banda(nomeDaBanda);
        //bandasRegistradas.Add(nomeDaBanda, banda);
        //Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        //PressioneUmaTecla();
    }

}
