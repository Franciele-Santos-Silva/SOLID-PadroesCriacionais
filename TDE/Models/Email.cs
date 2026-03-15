using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using interfaces;

public class Email: INotificacao
{
    public void Enviar()
    {
        ConsoleTraceListener.WriteLine("Email enviado");
    }
}