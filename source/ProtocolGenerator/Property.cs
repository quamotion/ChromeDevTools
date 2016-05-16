using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Property : Type
    {
        [JsonProperty("name")]
        public override string Name
        {
            get;
            set;
        }

        public bool Optional
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{base.TypeName} {this.Name}";
        }
    }
}
