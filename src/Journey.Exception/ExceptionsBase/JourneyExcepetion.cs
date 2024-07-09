using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public abstract class JourneyException : SystemException
    {
        public JourneyException(string message) : base(message)
        {

        }

        //obrigando todas as classes que tem herança com a JourneyException implementar essa função a baixo
        public abstract HttpStatusCode GetStatusCode();

        //obrigando todas as classes que tem herança com a journeyException enviar uma LISTA de messages
        public abstract IList<string> GetErrorMessages();
    }
}
