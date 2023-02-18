using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBlazor.Models
{
    public class Move
    {
        [JsonProperty("move")]
        public NameUrl MoveD {get;set;}
        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }

    public partial class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearnedtAt { get; set; }
        [JsonProperty("move_learn_method")]
        public NameUrl MoveLearnMethod { get; set; }
        [JsonProperty("version_group")]
        public NameUrl VersionGroup { get; set; }

    }
}
