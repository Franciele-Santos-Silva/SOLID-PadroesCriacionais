using Interfaces;
using System;

namespace Models
{
    public class Email : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando Email...");
        }
    }
}