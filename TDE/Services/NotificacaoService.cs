using System;
using Interfaces;
using Factories;

namespace Services
{
    public class NotificacaoService
    {
        public void EnviarNotificacao(string tipo)
        {
            if (!Enum.TryParse<TipoNotificacao>(tipo, true, out var tipoEnum))
            {
                throw new ArgumentException($"Tipo de notificação inválido: {tipo}");
            }

            INotificacao notificacao = NotificacaoFactory.CriarNotificacao(tipoEnum);

            notificacao.Enviar();
        }
    }
}