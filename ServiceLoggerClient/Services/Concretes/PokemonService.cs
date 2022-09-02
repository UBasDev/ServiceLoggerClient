using ServiceLoggerClient.Services.Abstracts;

namespace ServiceLoggerClient.Services.Concretes
{
    public class PokemonService : IPokemonService
    {
        public bool GetPokemonServiceStatus()
        {
            Console.WriteLine("asd");
            return true;
        }
    }
}
