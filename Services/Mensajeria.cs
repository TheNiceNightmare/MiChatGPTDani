
using MiChatGPTDani.Services;
using MiChatGPTDani.Services.Interfaces;

namespace MiChatGPTDani.Services
{
    public class Mensajeria : IMensajeria

    {
        public string Preguntame(string pregunta)
        {
            if (string.IsNullOrEmpty(pregunta))
            {
                return "Error en la pregunta";
            }
            var respuesta = "Yo soy Groot";

            return respuesta;
           
        }
    }
}
