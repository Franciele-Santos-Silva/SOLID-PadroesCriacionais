using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using Interface;

public class SMS: INotificacao
{
    public void Enviar()
    {
        console.WriteLine("SMS enviado");
    }
}