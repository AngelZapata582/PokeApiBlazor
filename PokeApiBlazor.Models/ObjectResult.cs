using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBlazor.Models
{
    public class ObjectResult
    {
        public string Next { get; set; }
        public string Prev { get; set; }
        [JsonProperty("result")]
        List<Pokemon> Pokemons { get; set; }
    }
}
