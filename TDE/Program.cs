using System;
using Services;
using Singleton;

class Program
{
    static void Main(string[] args)
    {
        var config = ConfiguracaoSistema.GetInstancia();
        Console.WriteLine($"Sistema: {config.NomeSistema} - Versão: {config.Versao}");
        Console.WriteLine();

        var servico = new NotificacaoService();

        string[] tipos = { "SMS", "Email", "WhatsApp" };
        foreach (var tipo in tipos)
        {
            Console.WriteLine($"Enviando {tipo}:");
            servico.EnviarNotificacao(tipo);
            Console.WriteLine();
        }
    }
}