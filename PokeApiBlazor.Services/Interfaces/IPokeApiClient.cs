using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeApiBlazor.Models;

namespace PokeApiBlazor.Services.Interfaces
{
    public interface IPokeApiClient
    {
        Task<IEnumerable<Pokemon>> GetAllPokemons();
        Task<Pokemon> GetPokemon(string name);
    }
}
