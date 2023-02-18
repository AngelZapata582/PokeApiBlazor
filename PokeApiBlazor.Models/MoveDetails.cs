using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBlazor.Models
{
    public class MoveDetails
    {
        //[JsonProperty("accuracy")]
        //public int Accuracy { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public NameUrl Type { get; set; }
        [JsonProperty("damage_class")]
        public NameUrl DamageClass { get; set; }
        [JsonProperty("generation")]
        public NameUrl Generation { get; set; }
    }
}
