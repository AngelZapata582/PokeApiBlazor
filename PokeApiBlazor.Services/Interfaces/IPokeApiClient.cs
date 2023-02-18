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
        Task<ObjectResult> GetAllPokemons(PaginationParameters parameters);
        Task<Pokemon> GetPokemon(string name);
        Task<MoveDetails> GetMoveDetails(string name);
    }
}
