using Interface;

public class WhatsApp: INotificacao
{
    public void Enviar()
    {
        console.WriteLine("Mensagem enviada pelo WhatsApp");
    }
}