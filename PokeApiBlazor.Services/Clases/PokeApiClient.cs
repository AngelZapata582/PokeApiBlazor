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

        public async Task<ObjectResult> GetAllPokemons(PaginationParameters parameters)
        {
            return JsonConvert.DeserializeObject<ObjectResult>(
            await http.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.Offset}"));
        }

        public async Task<MoveDetails> GetMoveDetails(string name)
        {
            return JsonConvert.DeserializeObject<MoveDetails>(
                await http.GetStringAsync($"move/{name}"));
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await http.GetStringAsync($"pokemon/{name}"));
        }
    }
}
