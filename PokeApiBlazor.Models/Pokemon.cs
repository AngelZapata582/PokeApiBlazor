﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBlazor.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("types")]
        public List<Type> Types { get; set; }

        [JsonProperty("sprites")]
        public List<Sprite> Sprites { get; set; }
    }
}
