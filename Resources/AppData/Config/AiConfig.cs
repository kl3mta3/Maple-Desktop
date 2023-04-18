using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleHome.Resources.AppData.Config
{
    public partial class AiConfig
    {
        [JsonProperty("openai_token")]
        public string? OpenAiApiToken { get; set; }


    }
}
