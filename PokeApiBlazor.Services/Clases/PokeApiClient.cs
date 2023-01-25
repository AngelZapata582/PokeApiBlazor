using Newtonsoft.Json;
using PokeApiBlazor.Models;
using PokeApiBlazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBlazor.Services.Clases
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient http;

        public PokeApiClient(HttpClient http)
        {
            this.http = http;
        }

        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            await http.GetStringAsync($"pokemon?limit=20&offset=020");
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await http.GetStringAsync($"pokemon/{name}"));
        }
    }
}
