//define o contrato para notificações, toda notificação, email, sms, whatsApp precisa implementar enviar();D do SOLID usar
public interface INotificacao
{
    public void Enviar();
}