using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleHome.Resources.AppData.Config
{
   public partial class Config
    {

        [JsonProperty("ai")]
        public static AiConfig? AiConfig { get; set; }


        [JsonProperty("music")]
        public static MusicConfig? MusicConfig { get; set; }



    }
}
